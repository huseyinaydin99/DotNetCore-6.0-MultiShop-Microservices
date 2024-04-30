using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.DTOs.FeatureSliderDTOs;
using MultiShop.Catalog.Services.FeatureSliderServices;

namespace MultiShop.Catalog.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class featureSlidersController : ControllerBase
{
    private readonly IFeatureSliderService _featureSliderService;

    public featureSlidersController(IFeatureSliderService featureSliderService)
    {
        _featureSliderService = featureSliderService;
    }

    [HttpGet]
    public async Task<IActionResult> FeatureSliderList()
    {
        var values = await _featureSliderService.GetAllFeatureSliderAsync();
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetFeatureSliderById(string id)
    {
        var values = await _featureSliderService.GetByIdFeatureSliderAsync(id);
        return Ok(values);
    }

    [HttpPost]
    public async Task<IActionResult> CreateFeatureSlider(CreateFeatureSliderDTO createfeatureSliderDTO)
    {
        await _featureSliderService.CreateFeatureSliderAsync(createfeatureSliderDTO);
        return Ok("Öne çıkan görsel başarıyla eklendi");
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteFeatureSlider(string id)
    {
        await _featureSliderService.DeleteFeatureSliderAsync(id);
        return Ok("Öne çıkan görsel başarıyla silindi");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateFeatureSlider(UpdateFeatureSliderDTO updatefeatureSliderDTO)
    {
        await _featureSliderService.UpdateFeatureSliderAsync(updatefeatureSliderDTO);
        return Ok("Öne çıkan görsel başarıyla güncellendi");
    }
}