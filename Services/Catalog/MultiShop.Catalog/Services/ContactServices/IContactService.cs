using MultiShop.Catalog.DTOs.ContactDTOs;

namespace MultiShop.Catalog.Services.ContactServices;

public interface IContactService
{
    Task<List<ResultContactDTO>> GettAllContactAsync();
    Task CreateContactAsync(CreateContactDTO createContactDTO);
    Task UpdateContactAsync(UpdateContactDTO updateContactDTO);
    Task DeleteContactAsync(string id);
    Task<GetByIdContactDTO> GetByIdContactAsync(string id);
}