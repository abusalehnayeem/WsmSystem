using System;
using System.Collections.Generic;

namespace WsmSystem.Erp.Local.Entities;

public partial class Section
{
    public int IdClient { get; set; }

    public int Id { get; set; }

    public int IdSubModule { get; set; }

    public int SectionCode { get; set; }

    public string SectionName { get; set; }

    public string IconName { get; set; }

    public string LastAction { get; set; }

    public string IdAuthorizationStatus { get; set; }

    public bool IsActive { get; set; }

    public string MakeBy { get; set; }

    public DateTime MakeDate { get; set; }

    public string UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual SubModule IdNavigation { get; set; }

    public virtual ICollection<Screen> Screen { get; set; } = new List<Screen>();
}
