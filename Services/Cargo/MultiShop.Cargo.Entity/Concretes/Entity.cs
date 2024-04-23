using MultiShop.Cargo.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.Entity.Concretes;

public class Entity<TId> : IEntityTimestamps
{
    public TId Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public DateTime? DeletedDate { get; set; }

    public Entity()
    {
        Id = default;
    }

    public Entity(TId id)
    {
        Id = id;
    }
}