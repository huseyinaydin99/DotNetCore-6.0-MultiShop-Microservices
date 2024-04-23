﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Cargo.Business.Abstracts;
using MultiShop.Cargo.Dto.Dtos.CargoCompanyDtos;
using MultiShop.Cargo.Entity.Concretes;

namespace MultiShop.Cargo.WebAPI.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class CargoCompaniesController : ControllerBase
{
    private readonly ICargoCompanyService _cargoCompanyService;

    public CargoCompaniesController(ICargoCompanyService cargoCompanyService)
    {
        _cargoCompanyService = cargoCompanyService;
    }

    [HttpGet]
    public IActionResult CargoCompanyList()
    {
        var values = _cargoCompanyService.TGetAll();
        return Ok(values);
    }

    [HttpPost]
    public IActionResult CreateCargoCompany(CreateCargoCompanyDto createCargoCompanyDto)
    {
        CargoCompany cargoCompany = new CargoCompany()
        {
            CargoCompanyName = createCargoCompanyDto.CargoCompanyName
        };
        _cargoCompanyService.TInsert(cargoCompany);
        return Ok("Kargo Şirketi Başarıyla Oluşturuldu");
    }

    [HttpDelete]
    public IActionResult RemoveCargoCompany(int id)
    {
        _cargoCompanyService.TDelete(id);
        return Ok("Kargo Şirketi Başarıyla Silindi");
    }

    [HttpGet("{id}")]
    public IActionResult GetCargoCompanyById(int id)
    {
        var values = _cargoCompanyService.TGetById(id);
        return Ok(values);
    }

    [HttpPut]
    public IActionResult UpdateCargoCompany(UpdateCargoCompanyDto updateCargoCompanyDto)
    {
        CargoCompany cargoCompany = new CargoCompany()
        {
            Id = updateCargoCompanyDto.CargoCompanyId,
            CargoCompanyName = updateCargoCompanyDto.CargoCompanyName
        };
        _cargoCompanyService.TUpdate(cargoCompany);
        return Ok("Kargo Şirketi Başarıyla Güncellendi");
    }
}