﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace WsmSystem.Erp.Local.Models;

public partial class PhraseTag
{
    public int IdClient { get; set; }

    public int Id { get; set; }

    public string PhraseName { get; set; } = null!;

    public string? UsageIn { get; set; }

    public bool? IsActive { get; set; }

    public string LastAction { get; set; } = null!;

    public string MakeBy { get; set; } = null!;

    public DateTime MakeDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}