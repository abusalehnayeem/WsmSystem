using System;
using System.Collections.Generic;

namespace WsmSystem.Erp.Local.Entities;

public partial class AppClient
{
    public int Id { get; set; }

    public string AppClientName { get; set; }

    public string ApplicationKey { get; set; }

    public DateTime? ExpireDate { get; set; }

    /// <summary>
    /// ((0))
    /// </summary>
    public bool? IsActive { get; set; }

    public string LastAction { get; set; }

    public string MakeBy { get; set; }

    /// <summary>
    /// ((getdate()))
    /// </summary>
    public DateTime MakeDate { get; set; }

    public string UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<ClientCompany> ClientCompany { get; set; } = new List<ClientCompany>();
}
