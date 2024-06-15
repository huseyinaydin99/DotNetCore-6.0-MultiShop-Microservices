using Microsoft.AspNetCore.Mvc;
using MultiShop.RapidApi.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace MultiShop.RapidApi.Controllers;

public class ECommerceController : Controller
{
    public async Task<IActionResult> ECommerceList()
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://real-time-product-search.p.rapidapi.com/search?q=fare&country=us&language=en&limit=30&sort_by=BEST_MATCH&product_condition=ANY&min_rating=ANY"),
            Headers =
            {
                { "x-rapidapi-key", "dd3fa5539bmsh3b20c335e1895adp104c66jsn47d0556c5e5e" },
                { "x-rapidapi-host", "real-time-product-search.p.rapidapi.com" },
            },
        };
        using (var response = await client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<ECommerceViewModel>(body);
            return View(values.data);
        }
    }
}