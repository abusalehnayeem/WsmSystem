using System;
using System.Collections.Generic;

namespace WsmSystem.Erp.Local.Entities;

public partial class Screen
{
    public int IdClient { get; set; }

    public int Id { get; set; }

    public int IdSection { get; set; }

    public int ScreenCode { get; set; }

    public string ScreenName { get; set; }

    public short? Ordinal { get; set; }

    public string Uri { get; set; }

    public string Description { get; set; }

    public bool IsRequiredForApproval { get; set; }

    public bool IsFinancialScreen { get; set; }

    public string IconName { get; set; }

    public string LastAction { get; set; }

    public string IdAuthorizationStatus { get; set; }

    public bool IsActive { get; set; }

    public string MakeBy { get; set; }

    public DateTime MakeDate { get; set; }

    public string UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Section IdNavigation { get; set; }
}
