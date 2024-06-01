using Microsoft.AspNetCore.Mvc;
using MultiShop.Images.WebUI.DAL.Entities;
using MultiShop.Images.WebUI.Services;

namespace MultiShop.Images.WebUI.Controllers;

public class DefaultController : Controller
{
    private readonly ICloudStorageService _cloudStorageService;

    public DefaultController(ICloudStorageService cloudStorageService)
    {
        _cloudStorageService = cloudStorageService;
    }

    private async Task GenerateSignedUrl(ImageDrive image)
    { 
        if (!string.IsNullOrWhiteSpace(image.SavedFileName))
        {
            image.SignedUrl = await _cloudStorageService.GetSignedUrlAsync(image.SavedFileName);
        }
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }


    [HttpPost]
    public async Task<IActionResult> Create([Bind("Id,Name,Age,Photo,SavedUrl,SavedFileName")] ImageDrive image)
    {
        if (ModelState.IsValid)
        {
            if (image.Photo != null)
            {
                image.SavedFileName = GenerateFileNameToSave(image.Photo.FileName);
                image.SavedUrl = await _cloudStorageService.UploadFileAsync(image.Photo, image.SavedFileName);
            }
            return RedirectToAction("Create");
        }
        return View(image);
    }

    private string? GenerateFileNameToSave(string incomingFileName)
    {
        var fileName = Path.GetFileNameWithoutExtension(incomingFileName);
        var extension = Path.GetExtension(incomingFileName);
        return $"{fileName}-{DateTime.Now.ToUniversalTime().ToString("yyyyMMddHHmmss")}{extension}";
    }
}