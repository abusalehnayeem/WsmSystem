using System;
using System.Collections.Generic;

namespace WsmSystem.Erp.Local.Entities;

public partial class Module
{
    public int IdClient { get; set; }

    public int Id { get; set; }

    public int ModuleCode { get; set; }

    public string ModuleName { get; set; }

    public string IconName { get; set; }

    public string LastAction { get; set; }

    public string IdAuthorizationStatus { get; set; }

    public bool IsActive { get; set; }

    public string MakeBy { get; set; }

    public DateTime MakeDate { get; set; }

    public string UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public short? Ordinal { get; set; }

    public virtual ICollection<SubModule> SubModule { get; set; } = new List<SubModule>();
}
