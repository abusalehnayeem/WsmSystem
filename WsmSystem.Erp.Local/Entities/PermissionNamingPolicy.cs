using System;
using System.Collections.Generic;

namespace WsmSystem.Erp.Local.Entities;

public partial class PermissionNamingPolicy
{
    public int IdClient { get; set; }

    public int Id { get; set; }

    public string LevelName { get; set; }

    public int LevelLength { get; set; }

    public int LevelStartPoint { get; set; }

    public int LevelEndPoint { get; set; }

    public int LevelIncrementBy { get; set; }

    public string LastAction { get; set; }

    public string IdAuthorizationStatus { get; set; }

    public bool? IsActive { get; set; }

    public string MakeBy { get; set; }

    public DateTime MakeDate { get; set; }

    public string UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
