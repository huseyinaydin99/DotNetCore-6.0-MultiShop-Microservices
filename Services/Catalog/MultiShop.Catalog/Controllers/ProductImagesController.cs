using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.DTOs.ProductImageDTOs;
using MultiShop.Catalog.Services.ProductImageServices;

namespace MultiShop.Catalog.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class ProductImagesController : ControllerBase
{
    private readonly IProductImageService _productImageService;
    public ProductImagesController(IProductImageService ProductImageService)
    {
        _productImageService = ProductImageService;
    }

    [HttpGet]
    public async Task<IActionResult> ProductImageList()
    {
        var values = await _productImageService.GetAllProductImageAsync();
        return Ok(values);
    }

    [HttpGet("ProductImagesByProductId/{id}")]
    public async Task<IActionResult> ProductImagesByProductId(string id)
    {
        var values = await _productImageService.GetByProductIdProductImageAsync(id);
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProductImageById(string id)
    {
        var values = await _productImageService.GetByIdProductImageAsync(id);
        return Ok(values);
    }

    [HttpPost]
    public async Task<IActionResult> CreateProductImage(CreateProductImageDTO createProductImageDto)
    {
        await _productImageService.CreateProductImageAsync(createProductImageDto);
        return Ok("Ürün görselleri başarıyla eklendi");
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteProductImage(string id)
    {
        await _productImageService.DeleteProductImageAsync(id);
        return Ok("Ürün görselleri başarıyla silindi");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateProductImage(UpdateProductImageDTO updateProductImageDto)
    {
        await _productImageService.UpdateProductImageAsync(updateProductImageDto);
        return Ok("Ürün görselleri başarıyla güncellendi");
    }
}