﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 5/24/2022 6:06:01 PM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

#nullable enable annotations
#nullable disable warnings

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Text.Json.Serialization;

namespace WsmSystem.Erp.Domain
{
    public  class ClientInfo {

        public ClientInfo()
        {
           
        }

        public virtual int Id { get; set; }

        public virtual int IdAppClient { get; set; }

        public virtual string? CompanyName { get; set; }

        public virtual string? CompanyEmail { get; set; }

        public virtual string? CompanyUrl { get; set; }

        public virtual string? CompanyAddress { get; set; }

        public virtual string? LogoUrl { get; set; }

        public virtual bool IsActive { get; set; }

        public virtual string LastAction { get; set; }

        public virtual string MakeBy { get; set; }

        public virtual DateTime MakeDate { get; set; }

        public virtual string? UpdateBy { get; set; }

        public virtual DateTime? UpdateDate { get; set; }

        public virtual AppClient AppClient { get; set; }

    }

}
