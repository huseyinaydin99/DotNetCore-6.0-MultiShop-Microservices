using MultiShop.Cargo.Business.Abstracts;
using MultiShop.Cargo.DataAccess.Abstracts;
using MultiShop.Cargo.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.Business.Concrete;

public class CargoCustomerManager : ICargoCustomerService
{
    private readonly ICargoCustomerDal _cargoCustomerDal;

    public CargoCustomerManager(ICargoCustomerDal cargoCustomerDal)
    {
        _cargoCustomerDal = cargoCustomerDal;
    }

    public void TDelete(int id)
    {
        _cargoCustomerDal.Delete(id);
    }

    public List<CargoCustomer> TGetAll()
    {
       return _cargoCustomerDal.GetAll();
    }

    public CargoCustomer TGetById(int id)
    {
        return _cargoCustomerDal.GetById(id);
    }

    public void TInsert(CargoCustomer entity)
    {
        _cargoCustomerDal.Insert(entity);
    }

    public void TUpdate(CargoCustomer entity)
    {
        _cargoCustomerDal.Update(entity);
    }
}