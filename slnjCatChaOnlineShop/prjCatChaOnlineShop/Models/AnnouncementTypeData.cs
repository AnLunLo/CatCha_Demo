﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace prjCatChaOnlineShop.Models;

public partial class AnnouncementTypeData
{
    public int AnnouncementTypeId { get; set; }

    public string AnnouncementTypeName { get; set; }

    public virtual ICollection<GameShopAnnouncement> GameShopAnnouncement { get; set; } = new List<GameShopAnnouncement>();
}