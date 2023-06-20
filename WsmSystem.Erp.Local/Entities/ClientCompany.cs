using System;
using System.Collections.Generic;

namespace WsmSystem.Erp.Local.Entities;

public partial class ClientCompany
{
    public int IdClient { get; set; }

    public int IdAppClient { get; set; }

    public string CompanyShortCode { get; set; }

    public string CompanyName { get; set; }

    public string CompanyFullName { get; set; }

    public string CompanyTelephone { get; set; }

    public string CompanyFax { get; set; }

    public string CompanyEmail { get; set; }

    public string CompanyUrl { get; set; }

    public string CompanyAddress { get; set; }

    public string CompanyIdentificationNo { get; set; }

    public byte[] CompanyLogo { get; set; }

    public bool? IsActive { get; set; }

    public bool IsDefault { get; set; }

    public bool? ExcludeSocialSecurity { get; set; }

    public bool? ExcludeSalaryTax { get; set; }

    public string SocialSecurityNumber { get; set; }

    public string LastAction { get; set; }

    public string MakeBy { get; set; }

    public DateTime MakeDate { get; set; }

    public string UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual AppClient IdAppClientNavigation { get; set; }
}
