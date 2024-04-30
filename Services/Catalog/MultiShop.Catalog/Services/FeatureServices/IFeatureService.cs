using MultiShop.Catalog.DTOs.FeatureDTOs;

namespace MultiShop.Catalog.Services.FeatureServices;

public interface IFeatureService
{
    Task<List<ResultFeatureDTO>> GetAllFeatureAsync();
    Task CreateFeatureAsync(CreateFeatureDTO createFeatureDTO);
    Task UpdateFeatureAsync(UpdateFeatureDTO updateFeatureDTO);
    Task DeleteFeatureAsync(string id);
    Task<GetByIdFeatureDTO> GetByIdFeatureAsync(string id);
}