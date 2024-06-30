using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MultiShop.WebUI.Services.CommentServices;
using MultiShop.WebUI.Services.StatisticService.CatalogStatisticService;
using MultiShop.WebUI.Services.StatisticServices.DiscountStatisticServices;
using MultiShop.WebUI.Services.StatisticServices.MessageStatisticServices;
using MultiShop.WebUI.Services.StatisticServices.UserStatisticServices;

namespace MultiShop.WebUI.Areas.Admin.Controllers;

[Area("Admin")]
[AllowAnonymous]
public class StatisticController : Controller
{
    private readonly ICatalogStatisticService _catalogStatisticService;
    private readonly ICommentService _commentService;
    private readonly IUserStatisticService _userStatisticService;
    private readonly IDiscountStatisticService _discountStatisticService;
    private readonly IMessageStatisticService _messageStatisticService;

    public StatisticController(ICatalogStatisticService catalogStatisticService, ICommentService commentService, IUserStatisticService userStatisticService, IDiscountStatisticService discountStatisticService, IMessageStatisticService messageStatisticService)
    {
        _catalogStatisticService = catalogStatisticService;
        _commentService = commentService;
        _userStatisticService = userStatisticService;
        _discountStatisticService = discountStatisticService;
        _messageStatisticService = messageStatisticService;
    }

    public async Task<IActionResult> Index()
    {
        var getBrandCount = await _catalogStatisticService.GetBrandCount();
        var getProductCount = await _catalogStatisticService.GetProductCount();
        var getCategoryCount = await _catalogStatisticService.GetCategoryCount();

        var getUserCount = await _userStatisticService.GetUsercount();

        var getMaxPriceProductName = await _catalogStatisticService.GetMaxPriceProductName();
        var getMinPriceProductName = await _catalogStatisticService.GetMinPriceProductName();

        var getTotalCommentCount = await _commentService.GetTotalCommentCount();
        var getActiveCommentCount = await _commentService.GetActiveCommentCount();
        var getPassiveCommentCount = await _commentService.GetPassiveCommentCount();

        var getDiscountCouponCount = await _discountStatisticService.GetDiscountCouponCount();

        var getMessageTotalCount = await _messageStatisticService.GetTotalMessageCount();

        ViewBag.getBrandCount = getBrandCount;
        ViewBag.getProductCount = getProductCount;
        ViewBag.getCategoryCount = getCategoryCount;

        ViewBag.getUserCount = getUserCount;

        ViewBag.getMaxPriceProductName = getMaxPriceProductName;
        ViewBag.getMinPriceProductName = getMinPriceProductName;

        ViewBag.getTotalCommentCount = getTotalCommentCount;
        ViewBag.getActiveCommentCount = getActiveCommentCount;
        ViewBag.getPassiveCommentCount = getPassiveCommentCount;

        ViewBag.getDiscountCouponCount = getDiscountCouponCount;

        ViewBag.getMessageTotalCount = getMessageTotalCount;

        return View();
    }
}