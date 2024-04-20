using MultiShop.Order.Application.Features.CQRS.Commands.AddressCommands;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.AddressHandlers;

public class CreateAddressCommandHandler
{
    private readonly IRepository<Address> _repository;

    public CreateAddressCommandHandler(IRepository<Address> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateAddressCommand command)
    {
        await _repository.CreateAsync(new Address
        {
            City = command.City,
            Detail1 = command.Detail1,
            District = command.District,
            UserId = command.UserId,
            Country = command.Country,
            Description = command.Description,
            Detail2 = command.Detail2,
            Email = command.Email,
            Name = command.Name,
            Phone = command.Phone,
            Surname = command.Surname,
            ZipCode = command.ZipCode
        });
    }
}