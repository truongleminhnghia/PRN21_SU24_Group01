﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DiamondShopSys.Data.Models;

public partial class OrderDetail
{
    public int OrderDetailId { get; set; }

    public int? ProId { get; set; }

    public int? OrderId { get; set; }

    public int Quantity { get; set; }

    public double? Discount { get; set; }

    public double? UnitPrice { get; set; }

    public double? DiscountAmount { get; set; }

    public double? TotalAmonut { get; set; }

    public double? Amount { get; set; }

    public virtual Order Order { get; set; }

    public virtual Product Pro { get; set; }
}