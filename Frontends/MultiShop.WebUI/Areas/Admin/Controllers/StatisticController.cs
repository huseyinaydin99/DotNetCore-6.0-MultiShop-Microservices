using Microsoft.AspNetCore.Mvc;
using MultiShop.WebUI.Services.CommentServices;
using MultiShop.WebUI.Services.StatisticService.CatalogStatisticService;
using MultiShop.WebUI.Services.StatisticServices.UserStatisticServices;

namespace MultiShop.WebUI.Areas.Admin.Controllers;

public class StatisticController : Controller
{
    private readonly ICatalogStatisticService _catalogStatisticService;
    private readonly ICommentService _commentService;
    private readonly IUserStatisticService _userStatisticService;

    public StatisticController(ICatalogStatisticService catalogStatisticService, ICommentService commentService, IUserStatisticService userStatisticService,)
    {
        _catalogStatisticService = catalogStatisticService;
        _commentService = commentService;
        _userStatisticService = userStatisticService;
    }

    public async Task<IActionResult> Index()
    {
        var getBrandCount = await _catalogStatisticService.GetBrandCount();
        var getProductCount = await _catalogStatisticService.GetProductCount();
        var getCategoryCount = await _catalogStatisticService.GetCategoryCount();

        var getUserCount = await _userStatisticService.GetUsercount();

        var getMaxPriceProductName = await _catalogStatisticService.GetMaxPriceProductName();
        var getMinPriceProductName = await _catalogStatisticService.GetMinPriceProductName();

        ViewBag.getBrandCount = getBrandCount;
        ViewBag.getProductCount = getProductCount;
        ViewBag.getCategoryCount = getCategoryCount;

        ViewBag.getUserCount = getUserCount;

        ViewBag.getMaxPriceProductName = getMaxPriceProductName;
        ViewBag.getMinPriceProductName = getMinPriceProductName;
        return View();
    }
}