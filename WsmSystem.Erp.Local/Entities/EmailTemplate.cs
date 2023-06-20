using System;
using System.Collections.Generic;

namespace WsmSystem.Erp.Local.Entities;

public partial class EmailTemplate
{
    public int IdClient { get; set; }

    public int Id { get; set; }

    public string TemplateName { get; set; }

    public string Subject { get; set; }

    public int IdServiceType { get; set; }

    public string TemplateBody { get; set; }

    public string IdAuthorizationStatus { get; set; }

    public bool? IsActive { get; set; }

    public string LastAction { get; set; }

    public string MakeBy { get; set; }

    public DateTime MakeDate { get; set; }

    public string UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
