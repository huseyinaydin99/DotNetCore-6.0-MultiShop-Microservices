using MultiShop.Catalog.DTOs.CategoryDTOs;

namespace MultiShop.Catalog.Services.CategoryServices;

public interface ICategoryService
{
    Task<List<ResultCategoryDTO>> GetAllCategoryAsync();
    Task CreateCategoryAsync(CreateCategoryDTO createCategoryDTO);
    Task UpdateCategoryAsync(UpdateCategoryDTO updateCategoryDTO);
    Task DeleteCategoryAsync(string id);
    Task<GetByIdCategoryDTO> GetByIdCategoryAsync(string id);
}
