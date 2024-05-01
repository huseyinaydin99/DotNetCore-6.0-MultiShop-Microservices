using MultiShop.Catalog.DTOs.ProductDTOs;

namespace MultiShop.Catalog.Services.ProductServices;

public interface IProductService
{
    Task<List<ResultProductDTO>> GetAllProductAsync();
    Task CreateProductAsync(CreateProductDTO createProductDto);
    Task UpdateProductAsync(UpdateProductDTO updateProductDto);
    Task DeleteProductAsync(string id);
    Task<GetByIdProductDTO> GetByIdProductAsync(string id);
    Task<List<ResultProductsWithCategoryDTO>> GetProductsWithCategoryAsync();
    Task<List<ResultProductsWithCategoryDTO>> GetProductsWithCategoryByCatetegoryIdAsync(string categoryId);
}