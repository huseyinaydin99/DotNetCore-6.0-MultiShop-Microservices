using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUI.Areas.User.Controllers;

public class UserLayoutController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}