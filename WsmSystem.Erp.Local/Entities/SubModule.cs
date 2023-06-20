using System;
using System.Collections.Generic;

namespace WsmSystem.Erp.Local.Entities;

public partial class SubModule
{
    public int IdClient { get; set; }

    public int Id { get; set; }

    public int IdModule { get; set; }

    public int SubModuleCode { get; set; }

    public string SubModuleName { get; set; }

    public string IconName { get; set; }

    public short? Ordinal { get; set; }

    public string IdAuthorizationStatus { get; set; }

    public bool IsActive { get; set; }

    public string LastAction { get; set; }

    public string MakeBy { get; set; }

    public DateTime MakeDate { get; set; }

    public string UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Module IdNavigation { get; set; }

    public virtual ICollection<Section> Section { get; set; } = new List<Section>();
}
