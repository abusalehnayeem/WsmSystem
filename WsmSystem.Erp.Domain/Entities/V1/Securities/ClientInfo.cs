﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 5/22/2022 12:09:13 PM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

namespace WsmSystem.Erp.Domain.Entities.V1.Securities
{
    public class ClientInfo : BaseEntity
    {
        public ClientInfo(int id, int idAppClient, string? companyName, string? companyEmail, string? companyUrl, string? companyAddress, string? logoUrl, AppClient appClient)
        {
            Id = id;
            IdAppClient = idAppClient;
            CompanyName = companyName;
            CompanyEmail = companyEmail;
            CompanyUrl = companyUrl;
            CompanyAddress = companyAddress;
            LogoUrl = logoUrl;
            AppClient = appClient ?? throw new ArgumentNullException(nameof(appClient));
        }

        public virtual int Id { get; set; }

        public virtual int IdAppClient { get; set; }

        public virtual string? CompanyName { get; set; }

        public virtual string? CompanyEmail { get; set; }

        public virtual string? CompanyUrl { get; set; }

        public virtual string? CompanyAddress { get; set; }

        public virtual string? LogoUrl { get; set; }

        public virtual AppClient AppClient { get; set; }
    }
}
