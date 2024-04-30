using MultiShop.Catalog.DTOs.SpecialOfferDTOs;

namespace MultiShop.Catalog.Services.SpecialOfferServices;

public interface ISpecialOfferService
{
    Task<List<ResultSpecialOfferDTO>> GetAllSpecialOfferAsync();
    Task CreateSpecialOfferAsync(CreateSpecialOfferDTO createSpecialOfferDTO);
    Task UpdateSpecialOfferAsync(UpdateSpecialOfferDTO updateSpecialOfferDTO);
    Task DeleteSpecialOfferAsync(string id);
    Task<GetByIdSpecialOfferDTO> GetByIdSpecialOfferAsync(string id);
}