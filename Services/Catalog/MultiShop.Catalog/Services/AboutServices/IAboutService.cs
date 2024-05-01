using MultiShop.Catalog.DTOs.AboutDTOs;

namespace MultiShop.Catalog.Services.AboutServices;

public interface IAboutService
{
    Task<List<ResultAboutDTO>> GetAllAboutAsync();
    Task CreateAboutAsync(CreateAboutDTO createAboutDTO);
    Task UpdateAboutAsync(UpdateAboutDTO updateAboutDTO);
    Task DeleteAboutAsync(string id);
    Task<GetByIdAboutDTO> GetByIdAboutAsync(string id);
}