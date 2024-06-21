using Microsoft.AspNetCore.Mvc;
using MultiShop.WebUI.Services.CatalogServices.CategoryServices;

namespace MultiShop.WebUI.Controllers;

public class UILayoutController : Controller
{
    private readonly ICategoryService _categoryService;

    public UILayoutController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        return null;
    }

    public async Task<IActionResult> _UILayout()
    {
        var values = await _categoryService.GetAllCategoryAsync();
        return View(values);
    }
}