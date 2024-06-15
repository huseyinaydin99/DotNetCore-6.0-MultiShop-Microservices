using Microsoft.AspNetCore.Mvc;
using MultiShop.RapidApi.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace MultiShop.RapidApi.Controllers;

public class DefaultController : Controller
{
    public async Task<IActionResult> WeatherDetail()
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://the-weather-api.p.rapidapi.com/api/weather/niğde"),
            Headers =
            {
                { "x-rapidapi-key", "dd3fa5539bmsh3b20c335e1895adp104c66jsn47d0556c5e5e" },
                { "x-rapidapi-host", "the-weather-api.p.rapidapi.com" },
            },
        };
        var body = "";
        using (var response = await client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            body = await response.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<WeatherViewModel.Rootobject>(body);
            ViewBag.cityTemp = values.data.temp;
            return View();
        }
    }

    public async Task<IActionResult> Exchange()
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://real-time-finance-data.p.rapidapi.com/currency-exchange-rate?from_symbol=USD&language=en&to_symbol=TRY"),
            Headers =
            {
                { "x-rapidapi-key", "dd3fa5539bmsh3b20c335e1895adp104c66jsn47d0556c5e5e" },
                { "x-rapidapi-host", "real-time-finance-data.p.rapidapi.com" },
            },
        };
        using (var response = await client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<ExchangeViewModel.Rootobject>(body);
            ViewBag.exchange_rate = values.data.exchange_rate;
            ViewBag.previus_close = values.data.previous_close;
            return View();
        }
    }
}