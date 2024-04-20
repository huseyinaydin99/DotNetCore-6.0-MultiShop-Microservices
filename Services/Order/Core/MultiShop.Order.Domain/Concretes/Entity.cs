using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiShop.Order.Domain.Abstract;

namespace MultiShop.Order.Domain.Concretes;

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