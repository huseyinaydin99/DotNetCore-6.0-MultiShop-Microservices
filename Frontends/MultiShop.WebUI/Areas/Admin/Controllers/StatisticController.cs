using Microsoft.AspNetCore.Mvc;
using MultiShop.WebUI.Services.CommentServices;
using MultiShop.WebUI.Services.StatisticService.CatalogStatisticService;

namespace MultiShop.WebUI.Areas.Admin.Controllers;

public class StatisticController : Controller
{
    private readonly ICatalogStatisticService _catalogStatisticService;
    private readonly ICommentService _commentService;

    public StatisticController(ICatalogStatisticService catalogStatisticService, ICommentService commentService)
    {
        _catalogStatisticService = catalogStatisticService;
        _commentService = commentService;
    }

    public async Task<IActionResult> Index()
    {
        var getBrandCount = await _catalogStatisticService.GetBrandCount();
        var getProductCount = await _catalogStatisticService.GetProductCount();
        var getCategoryCount = await _catalogStatisticService.GetCategoryCount();
        var getMaxPriceProductName = await _catalogStatisticService.GetMaxPriceProductName();
        var getMinPriceProductName = await _catalogStatisticService.GetMinPriceProductName();

        ViewBag.getBrandCount = getBrandCount;
        ViewBag.getProductCount = getProductCount;
        ViewBag.getCategoryCount = getCategoryCount;
        ViewBag.getMaxPriceProductName = getMaxPriceProductName;
        ViewBag.getMinPriceProductName = getMinPriceProductName;
        return View();
    }
}