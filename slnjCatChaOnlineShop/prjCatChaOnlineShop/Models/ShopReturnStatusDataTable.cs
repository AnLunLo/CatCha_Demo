﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace prjCatChaOnlineShop.Models;

public partial class ShopReturnStatusDataTable
{
    public int ProcessingStatusId { get; set; }

    public string StatusName { get; set; }

    public virtual ICollection<ShopReturnDataTable> ShopReturnDataTable { get; set; } = new List<ShopReturnDataTable>();
}