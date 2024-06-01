using Google.Apis.Auth.OAuth2;
using Google.Cloud.Storage.V1;
using Microsoft.Extensions.Options;

namespace MultiShop.Images.WebUI.Services;

public class CloudStorageService : ICloudStorageService
{
    private readonly GCSConfigOptions _options;
    private readonly ILogger<CloudStorageService> _logger;
    private readonly GoogleCredential _googleCredential;

    public CloudStorageService(IOptions<GCSConfigOptions> options, ILogger<CloudStorageService> logger)
    {
        _options = options.Value;
        _logger = logger;

        try
        {
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            if (environment == Environments.Production)
            {
                _googleCredential = GoogleCredential.FromJson(_options.GCPStorageAuthFile);
            }
            else
            {
                _googleCredential = GoogleCredential.FromFile(_options.GCPStorageAuthFile);
            }
        }
        catch (Exception ex)
        {
            _logger.LogError($"{ex.Message}");
            throw;
        }
    }
    public async Task DeleteFileAsync(string fileNameToDelete)
    {
        try
        {
            using (var storageClient = StorageClient.Create(_googleCredential))
            {
                await storageClient.DeleteObjectAsync(_options.GoogleCloudStorageBucketName, fileNameToDelete);
            }
            _logger.LogInformation($"İlgili: {fileNameToDelete} dosya silindi.");
        }
        catch (Exception ex)
        {
            _logger.LogError($"Dosya silinirken hata oluştu. {fileNameToDelete}: {ex.Message}");
            throw;
        }
    }

    public async Task<string> GetSignedUrlAsync(string fileNameToRead, int timeOutInMinutes = 30)
    {
        try
        {
            var sac = _googleCredential.UnderlyingCredential as ServiceAccountCredential;
            var urlSigner = UrlSigner.FromServiceAccountCredential(sac);
            // Zaman aşımı süresi 30 dakikadır. İşlem bu sürede gerçekleşmezse ilgili URL'e istekde bulunulamaz.
            var signedUrl = await urlSigner.SignAsync(_options.GoogleCloudStorageBucketName, fileNameToRead, TimeSpan.FromMinutes(timeOutInMinutes));
            _logger.LogInformation($"İlgili dosya için URL imzalandı. {fileNameToRead}");
            return signedUrl.ToString();
        }
        catch (Exception ex)
        {
            _logger.LogError($"İlgili dosya imzalanırken hata oldu dostum. {fileNameToRead}: {ex.Message}");
            throw;
        }
    }

    public async Task<string> UploadFileAsync(IFormFile fileToUpload, string fileNameToSave)
    {
        try
        {
            _logger.LogInformation($"Yükleniyor: {fileNameToSave} depolama alanı: {_options.GoogleCloudStorageBucketName}");
            using (var memoryStream = new MemoryStream())
            {
                await fileToUpload.CopyToAsync(memoryStream);
                // Create Storage Client from Google Credential
                using (var storageClient = StorageClient.Create(_googleCredential))
                {
                    // upload file stream
                    var uploadedFile = await storageClient.UploadObjectAsync(_options.GoogleCloudStorageBucketName, fileNameToSave, fileToUpload.ContentType, memoryStream);
                    _logger.LogInformation($"Yüklenen dosya: {fileNameToSave} ilgili depolama alanı: {_options.GoogleCloudStorageBucketName}");
                    return uploadedFile.MediaLink;
                }
            }
        }
        catch (Exception ex)
        {
            _logger.LogError($"Dosya cloud'un kovasına yüklenirken hata oldu dostum. {fileNameToSave}: {ex.Message}");
            throw;
        }
    }
}