﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace BookStore.Core.Entities.Models;

public partial class Status
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<Bookitem> Bookitems { get; set; } = new List<Bookitem>();
}