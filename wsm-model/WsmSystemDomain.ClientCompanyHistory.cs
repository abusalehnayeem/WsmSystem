﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 7/21/2023 10:48:20 AM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;

namespace WsmSystemModel
{
    public partial class ClientCompanyHistory {

        public ClientCompanyHistory()
        {
            OnCreated();
        }

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

        public bool IsActive { get; set; }

        public bool IsDefault { get; set; }

        public bool? ExcludeSocialSecurity { get; set; }

        public bool? ExcludeSalaryTax { get; set; }

        public string SocialSecurityNumber { get; set; }

        public string LastAction { get; set; }

        public string MakeBy { get; set; }

        public DateTime MakeDate { get; set; }

        public string UpdateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        #region Extensibility Method Definitions

        partial void OnCreated();

        #endregion
    }

}
