using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.DTOs.SpecialOfferDTOs;
using MultiShop.Catalog.Services.SpecialOfferServices;

namespace MultiShop.Catalog.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class SpecialOffersController : ControllerBase
{
    private readonly ISpecialOfferService _SpecialOfferService;
    public SpecialOffersController(ISpecialOfferService SpecialOfferService)
    {
        _SpecialOfferService = SpecialOfferService;
    }

    [HttpGet]
    public async Task<IActionResult> SpecialOfferList()
    {
        var values = await _SpecialOfferService.GetAllSpecialOfferAsync();
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetSpecialOfferById(string id)
    {
        var values = await _SpecialOfferService.GetByIdSpecialOfferAsync(id);
        return Ok(values);
    }

    [HttpPost]
    public async Task<IActionResult> CreateSpecialOffer(CreateSpecialOfferDTO createSpecialOfferDto)
    {
        await _SpecialOfferService.CreateSpecialOfferAsync(createSpecialOfferDto);
        return Ok("Özel teklif başarıyla eklendi");
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteSpecialOffer(string id)
    {
        await _SpecialOfferService.DeleteSpecialOfferAsync(id);
        return Ok("Özel teklif başarıyla silindi");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateSpecialOffer(UpdateSpecialOfferDTO updateSpecialOfferDto)
    {
        await _SpecialOfferService.UpdateSpecialOfferAsync(updateSpecialOfferDto);
        return Ok("Özel teklif başarıyla güncellendi");
    }
}