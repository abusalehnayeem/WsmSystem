using System;
using System.Collections.Generic;

namespace WsmSystem.Erp.Local.Entities;

public partial class RoleScreenLink
{
    public int IdClient { get; set; }

    public int Id { get; set; }

    public int IdRole { get; set; }

    public int IdScreen { get; set; }

    public string AccessRight { get; set; }

    public string LastAction { get; set; }

    public string IdAuthorizationStatus { get; set; }

    public bool IsActive { get; set; }

    public string MakeBy { get; set; }

    public DateTime MakeDate { get; set; }

    public string UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
