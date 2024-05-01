using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.DTOs.ProductDetailDTOs;
using MultiShop.Catalog.Services.ProductDetailDetailServices;

namespace MultiShop.Catalog.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class ProductDetailsController : ControllerBase
{
    private readonly IProductDetailService _productDetailService;

    public ProductDetailsController(IProductDetailService ProductDetailService)
    {
        _productDetailService = ProductDetailService;
    }

    [HttpGet]
    public async Task<IActionResult> ProductDetailList()
    {
        var values = await _productDetailService.GetAllProductDetailAsync();
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProductDetailById(string id)
    {
        var values = await _productDetailService.GetByIdProductDetailAsync(id);
        return Ok(values);
    }

    [HttpGet("GetProductDetailByProductId/{id}")]
    public async Task<IActionResult> GetProductDetailByProductId(string id)
    {
        var values = await _productDetailService.GetByProductIdProductDetailAsync(id);
        return Ok(values);
    }

    [HttpPost]
    public async Task<IActionResult> CreateProductDetail(CreateProductDetailDTO createProductDetailDTO)
    {
        await _productDetailService.CreateProductDetailAsync(createProductDetailDTO);
        return Ok("Ürün detayı başarıyla eklendi");
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteProductDetail(string id)
    {
        await _productDetailService.DeleteProductDetailAsync(id);
        return Ok("Ürün detayı başarıyla silindi");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateProductDetail(UpdateProductDetailDTO updateProductDetailDTO)
    {
        await _productDetailService.UpdateProductDetailAsync(updateProductDetailDTO);
        return Ok("Ürün detayı başarıyla güncellendi");
    }
}