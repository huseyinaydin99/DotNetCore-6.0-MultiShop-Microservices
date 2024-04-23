using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiShop.Cargo.Entity.Concretes;

namespace MultiShop.Cargo.DataAccess.Abstracts;

public interface IGenericDal<T> where T : Entity<int>, new()
{
    void Insert(T entity);
    void Update(T entity);
    void Delete(int id);
    T GetById(int id);
    List<T> GetAll();
}