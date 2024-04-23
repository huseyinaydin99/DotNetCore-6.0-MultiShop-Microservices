﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Cargo.Business.Abstracts;
using MultiShop.Cargo.Dto.Dtos.CargoDetailDtos;
using MultiShop.Cargo.Entity.Concretes;

namespace MultiShop.Cargo.WebApi.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class CargoDetailsController : ControllerBase
{
    private readonly ICargoDetailService _CargoDetailService;

    public CargoDetailsController(ICargoDetailService CargoDetailService)
    {
        _CargoDetailService = CargoDetailService;
    }

    [HttpGet]
    public IActionResult CargoDetailList()
    {
        var values = _CargoDetailService.TGetAll();
        return Ok(values);
    }

    [HttpPost]
    public IActionResult CreateCargoDetail(CreateCargoDetailDto createCargoDetailDto)
    {
        CargoDetail CargoDetail = new CargoDetail()
        {
           Barcode = createCargoDetailDto.Barcode,
           CargoCompanyId=createCargoDetailDto.CargoCompanyId,
           ReceiverCustomer=createCargoDetailDto.ReceiverCustomer,
           SenderCustomer= createCargoDetailDto.SenderCustomer
        };
        _CargoDetailService.TInsert(CargoDetail);
        return Ok("Kargo Detayları Başarıyla Oluşturuldu");
    }

    [HttpDelete]
    public IActionResult RemoveCargoDetail(int id)
    {
        _CargoDetailService.TDelete(id);
        return Ok("Kargo Detayları Başarıyla Silindi");
    }

    [HttpGet("{id}")]
    public IActionResult GetCargoDetailById(int id)
    {
        var values = _CargoDetailService.TGetById(id);
        return Ok(values);
    }

    [HttpPut]
    public IActionResult UpdateCargoDetail(UpdateCargoDetailDto updateCargoDetailDto)
    {
        CargoDetail CargoDetail = new CargoDetail()
        {
           Barcode = updateCargoDetailDto.Barcode,
           CargoCompanyId= updateCargoDetailDto.CargoCompanyId,
           Id=updateCargoDetailDto.CargoDetailId,
           ReceiverCustomer=updateCargoDetailDto.ReceiverCustomer,
           SenderCustomer=updateCargoDetailDto.SenderCustomer
           
        };
        _CargoDetailService.TUpdate(CargoDetail);
        return Ok("Kargo Detayları Başarıyla Güncellendi");
    }
}