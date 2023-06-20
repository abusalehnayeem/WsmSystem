using System;
using System.Collections.Generic;

namespace WsmSystem.Erp.Local.Entities;

public partial class UserWiseGroupMapping
{
    public int IdClient { get; set; }

    public int Id { get; set; }

    public int IdUser { get; set; }

    public int IdUserGroup { get; set; }

    public string LastAction { get; set; }

    public string IdAuthorizationStatus { get; set; }

    public bool? IsActive { get; set; }

    public string MakeBy { get; set; }

    public DateTime MakeDate { get; set; }

    public string UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual UserGroup Id1 { get; set; }

    public virtual Users IdNavigation { get; set; }
}
