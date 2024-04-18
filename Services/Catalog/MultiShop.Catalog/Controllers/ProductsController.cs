using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.DTOs.ProductDTOs;
using MultiShop.Catalog.Services.ProductServices;

namespace MultiShop.Catalog.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;
    public ProductsController(IProductService ProductService)
    {
        _productService = ProductService;
    }

    [HttpGet]
    public async Task<IActionResult> ProductList()
    {
        var values = await _productService.GettAllProductAsync();
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProductById(string id)
    {
        var values = await _productService.GetByIdProductAsync(id);
        return Ok(values);
    }

    [HttpPost]
    public async Task<IActionResult> CreateProduct(CreateProductDTO createProductDTO)
    {
        await _productService.CreateProductAsync(createProductDTO);
        return Ok("Ürün başarıyla eklendi");
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteProduct(string id)
    {
        await _productService.DeleteProductAsync(id);
        return Ok("Ürün başarıyla silindi");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateProduct(UpdateProductDTO updateProductDTO)
    {
        await _productService.UpdateProductAsync(updateProductDTO);
        return Ok("Ürün başarıyla güncellendi");
    }

    [HttpGet("ProductListWithCategory")]
    public async Task<IActionResult> ProductListWithCategory()
    {
        var values = await _productService.GetProductsWithCategoryAsync();
        return Ok(values);
    }

    [HttpGet("ProductListWithCategoryByCategoryId/{id}")]
    public async Task<IActionResult> ProductListWithCategoryByCategoryId(string id)
    {
        var values = await _productService.GetProductsWithCategoryByCatetegoryIdAsync(id);
        return Ok(values);
    }
}