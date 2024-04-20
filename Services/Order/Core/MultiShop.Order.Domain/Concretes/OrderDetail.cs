using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Domain.Concretes;

public class OrderDetail : Entity<int>
{
    public string ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal ProductPrice { get; set; }
    public int ProductAmount { get; set; }
    public decimal ProductTotalPrice { get; set; }
    public int OrderingId { get; set; }
    public Ordering Ordering { get; set; }
}