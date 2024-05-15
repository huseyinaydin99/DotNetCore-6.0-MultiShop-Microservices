﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.Entity.Concretes;

public class CargoCustomer : Entity<int>
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string District { get; set; }
    public string City { get; set; }
    public string Address { get; set; }
    public string? UserCustomerId { get; set; }
}