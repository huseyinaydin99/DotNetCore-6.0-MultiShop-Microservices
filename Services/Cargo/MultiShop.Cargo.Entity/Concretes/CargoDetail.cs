using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.Entity.Concretes;

public class CargoDetail : Entity<int>
{
    public string SenderCustomer { get; set; } //gönderen
    public string ReceiverCustomer { get; set; } //alıcı
    public int Barcode { get; set; }
    public int CargoCompanyId { get; set; }
    public CargoCompany CargoCompany { get; set; }
}