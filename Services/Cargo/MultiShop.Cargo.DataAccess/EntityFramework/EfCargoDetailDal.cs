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

public class EfCargoDetailDal : GenericRepository<CargoDetail>, ICargoDetailDal
{
    public EfCargoDetailDal(CargoContext context) : base(context)
    {

    }
}