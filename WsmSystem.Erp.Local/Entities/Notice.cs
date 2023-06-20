using System;
using System.Collections.Generic;

namespace WsmSystem.Erp.Local.Entities;

public partial class Notice
{
    public int IdClient { get; set; }

    public int Id { get; set; }

    public string Title { get; set; }

    public string NoticeBody { get; set; }

    public string AttachedFileUrl { get; set; }

    public bool IsPublished { get; set; }

    public DateTime? PublishedDate { get; set; }

    public string IdAuthorizationStatus { get; set; }

    public bool IsActive { get; set; }

    public string LastAction { get; set; }

    public string MakeBy { get; set; }

    public DateTime MakeDate { get; set; }

    public string UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
