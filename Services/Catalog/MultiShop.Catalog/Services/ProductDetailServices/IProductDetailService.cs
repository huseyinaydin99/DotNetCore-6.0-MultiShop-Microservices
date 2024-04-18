using MultiShop.Catalog.DTOs.ProductDetailDTOs;

namespace MultiShop.Catalog.Services.ProductDetailDetailServices;

public interface IProductDetailService
{
    Task<List<ResultProductDetailDTO>> GettAllProductDetailAsync();
    Task CreateProductDetailAsync(CreateProductDetailDTO createProductDetailDTO);
    Task UpdateProductDetailAsync(UpdateProductDetailDTO updateProductDetailDTO);
    Task DeleteProductDetailAsync(string id);
    Task<GetByIdProductDetailDTO> GetByIdProductDetailAsync(string id);
    Task<GetByIdProductDetailDTO> GetByProductIdProductDetailAsync(string id);
}