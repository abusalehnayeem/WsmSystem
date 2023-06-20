using System;
using System.Collections.Generic;

namespace WsmSystem.Erp.Local.Entities;

public partial class UserResource
{
    public int IdClient { get; set; }

    public int Id { get; set; }

    public string Url { get; set; }

    public int IdHttpMethod { get; set; }

    public string LastAction { get; set; }

    public string IdAuthorizationStatus { get; set; }

    public bool? IsActive { get; set; }

    public string MakeBy { get; set; }

    public DateTime MakeDate { get; set; }

    public string UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual HttpMethod IdNavigation { get; set; }

    public virtual ICollection<UserRoleWiseResourceMapping> UserRoleWiseResourceMapping { get; set; } = new List<UserRoleWiseResourceMapping>();
}
