﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 9/5/2023 5:26:47 PM
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

namespace WsmSystem.Erp.Core.Entities
{
    public partial class ClientInfo {

        public ClientInfo()
        {
            this.IdAuthorizationStatus = @"N";
            OnCreated();
        }

        public int Id { get; set; }

        public int IdApplicationInfo { get; set; }

        public string CompanyName { get; set; }

        public string CompanyEmail { get; set; }

        public string CompanyUrl { get; set; }

        public string CompanyAddress { get; set; }

        public string LogoUrl { get; set; }

        public bool IsActive { get; set; }

        public string IdAuthorizationStatus { get; set; }

        public string LastAction { get; set; }

        public string MakeBy { get; set; }

        public DateTime MakeDate { get; set; }

        public string UpdateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        public bool? IsDefault { get; set; }

        public virtual ApplicationInfo ApplicationInfo { get; set; }

        #region Extensibility Method Definitions

        partial void OnCreated();

        #endregion
    }

}