using MultiShop.Catalog.DTOs.FeatureSliderDTOs;

namespace MultiShop.Catalog.Services.FeatureSliderServices;

public interface IFeatureSliderService
{
    Task<List<ResultFeatureSliderDTO>> GetAllFeatureSliderAsync();
    Task CreateFeatureSliderAsync(CreateFeatureSliderDTO createFeatureSliderDTO);
    Task UpdateFeatureSliderAsync(UpdateFeatureSliderDTO updateFeatureSliderDTO);
    Task DeleteFeatureSliderAsync(string id);
    Task<GetByIdFeatureSliderDTO> GetByIdFeatureSliderAsync(string id);
    Task FeatureSliderChageStatusToTrue(string id);
    Task FeatureSliderChageStatusToFalse(string id);
}