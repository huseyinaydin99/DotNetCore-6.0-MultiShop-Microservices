using MultiShop.Cargo.DataAccess.Abstracts;
using MultiShop.Cargo.DataAccess.Concretes;
using MultiShop.Cargo.DataAccess.Repositories;
using MultiShop.Cargo.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.DataAccess.EntityFramework;

public class EfCargoCustomerDal : GenericRepository<CargoCustomer>, ICargoCustomerDal
{
    private readonly CargoContext _cargoContext;

    public EfCargoCustomerDal(CargoContext context, CargoContext cargoContext) : base(context)
    {
        _cargoContext = cargoContext;
    }

    public CargoCustomer GetCargoCustomerById(string id)
    {
        var values = _cargoContext.CargoCustomers.Where(x => x.UserCustomerId == id).FirstOrDefault();
        return values;
    }
}
