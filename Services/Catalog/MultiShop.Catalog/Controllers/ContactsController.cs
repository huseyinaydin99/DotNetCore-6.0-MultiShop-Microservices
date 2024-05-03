using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.DTOs.ContactDTOs;
using MultiShop.Catalog.Services.ContactServices;

namespace MultiShop.Catalog.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class ContactsController : ControllerBase
{
    private readonly IContactService _ContactService;

    public ContactsController(IContactService ContactService)
    {
        _ContactService = ContactService;
    }

    [HttpGet]
    public async Task<IActionResult> ContactList()
    {
        var values = await _ContactService.GettAllContactAsync();
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetContactById(string id)
    {
        var values = await _ContactService.GetByIdContactAsync(id);
        return Ok(values);
    }

    [HttpPost]
    public async Task<IActionResult> CreateContact(CreateContactDTO createContactDTO)
    {
        await _ContactService.CreateContactAsync(createContactDTO);
        return Ok("Mesaj başarıyla eklendi");
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteContact(string id)
    {
        await _ContactService.DeleteContactAsync(id);
        return Ok("Mesaj başarıyla silindi");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateContact(UpdateContactDTO updateContactDTO)
    {
        await _ContactService.UpdateContactAsync(updateContactDTO);
        return Ok("Mesaj başarıyla güncellendi");
    }
}