using Microsoft.AspNetCore.Mvc;
using MultiShop.WebUI.Services.StatisticService.CatalogStatisticService;

namespace MultiShop.WebUI.Areas.Admin.Controllers;

public class StatisticController : Controller
{
    private readonly ICatalogStatisticService _catalogStatisticService;

    public StatisticController(ICatalogStatisticService catalogStatisticService)
    {
        _catalogStatisticService = catalogStatisticService;
    }

    public async Task<IActionResult> Index()
    {
        var values = await _catalogStatisticService.GetBrandCount();
        ViewBag.v = values;
        return View();
    }
}