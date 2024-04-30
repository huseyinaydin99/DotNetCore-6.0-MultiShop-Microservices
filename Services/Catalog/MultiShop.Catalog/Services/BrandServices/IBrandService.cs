using MultiShop.Catalog.DTOs.BrandDTOs;

namespace MultiShop.Catalog.Services.BrandServices;

public interface IBrandService
{
    Task<List<ResultBrandDTO>> GetAllBrandAsync();
    Task CreateBrandAsync(CreateBrandDTO createBrandDTO);
    Task UpdateBrandAsync(UpdateBrandDTO updateBrandDTO);
    Task DeleteBrandAsync(string id);
    Task<GetByIdBrandDTO> GetByIdBrandAsync(string id);
}