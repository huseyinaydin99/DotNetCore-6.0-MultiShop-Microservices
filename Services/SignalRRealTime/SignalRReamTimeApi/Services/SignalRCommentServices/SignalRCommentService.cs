using Newtonsoft.Json;
using System.Net.Http;

namespace MultiShop.SignalRRealTimeApi.Services.SignalRCommentServices;

public class SignalRCommentService : ISignalRCommentService
{
    private readonly IHttpClientFactory _httpClientFactory;

    public SignalRCommentService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    /*private readonly HttpClient _httpClient;

    public SignalRCommentService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }*/

    public async Task<int> GetTotalCommentCount()
    {
        /*var responseMessage = await _httpClient.GetAsync("comments/GetTotalCommentCount");
        var values = await responseMessage.Content.ReadFromJsonAsync<int>();
        return values;*/
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("http://localhost:7021/api/CommentStatistics");
        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        var commentCount = JsonConvert.DeserializeObject<int>(jsonData);
        return commentCount;
    }
}