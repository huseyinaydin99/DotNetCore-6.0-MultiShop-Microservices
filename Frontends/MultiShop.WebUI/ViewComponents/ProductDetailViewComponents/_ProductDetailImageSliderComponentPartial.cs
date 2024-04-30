using Microsoft.AspNetCore.Mvc;
using MultiShop.Dto.CatalogDtos.ProductDtos;
using MultiShop.Dto.CatalogDtos.ProductImageDtos;
using MultiShop.WebUI.Services.CatalogServices.ProductImageServices;
using Newtonsoft.Json;

namespace MultiShop.WebUI.ViewComponents.ProductDetailViewComponents;

public class _ProductDetailImageSliderComponentPartial : ViewComponent
{
    private readonly IProductImageService _productImageService;

    public _ProductDetailImageSliderComponentPartial(IProductImageService productImageService)
    {
        _productImageService = productImageService;
    }

    public async Task<IViewComponentResult> InvokeAsync(string id)
    {
        var values = await _productImageService.GetByProductIdProductImageAsync(id);
        return View(values);
    }
}