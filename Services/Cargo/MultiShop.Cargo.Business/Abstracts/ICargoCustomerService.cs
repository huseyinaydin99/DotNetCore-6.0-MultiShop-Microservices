using MultiShop.Cargo.Business.Abstracts;
using MultiShop.Cargo.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.Business.Abstracts;

public interface ICargoCustomerService : IGenericService<CargoCustomer>
{
    CargoCustomer TGetCargoCustomerById(string id);
}