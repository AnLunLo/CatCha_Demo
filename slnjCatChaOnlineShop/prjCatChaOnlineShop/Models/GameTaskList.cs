﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace prjCatChaOnlineShop.Models;

public partial class GameTaskList
{
    public int TaskId { get; set; }

    public string TaskName { get; set; }

    public string TaskDescription { get; set; }

    public int? TaskRequireTime { get; set; }

    public decimal? TaskReward { get; set; }

    public int? TaskConditionId { get; set; }

    public virtual ICollection<GameMemberTask> GameMemberTask { get; set; } = new List<GameMemberTask>();

    public virtual GameTaskConditionData TaskCondition { get; set; }
}