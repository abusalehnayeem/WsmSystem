using System;
using System.Collections.Generic;

namespace WsmSystem.Erp.Local.Entities;

public partial class UserGroup
{
    public int IdClient { get; set; }

    public int Id { get; set; }

    public string GroupName { get; set; }

    public string GroupDescription { get; set; }

    public string LastAction { get; set; }

    public string IdAuthorizationStatus { get; set; }

    public bool? IsActive { get; set; }

    public string MakeBy { get; set; }

    public DateTime MakeDate { get; set; }

    public string UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<UserGroupWiseRoleMapping> UserGroupWiseRoleMapping { get; set; } = new List<UserGroupWiseRoleMapping>();

    public virtual ICollection<UserWiseGroupMapping> UserWiseGroupMapping { get; set; } = new List<UserWiseGroupMapping>();
}
