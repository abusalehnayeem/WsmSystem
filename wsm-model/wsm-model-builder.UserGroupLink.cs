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
    public  class UserGroupLink {

        public UserGroupLink()
        {
           
        }

        public virtual int IdClient { get; set; }

        public virtual int Id { get; set; }

        public virtual int IdUser { get; set; }

        public virtual int IdUserGroup { get; set; }

        public virtual bool IsActive { get; set; }

        public virtual string LastAction { get; set; }

        public virtual string MakeBy { get; set; }

        public virtual DateTime MakeDate { get; set; }

        public virtual string? UpdateBy { get; set; }

        public virtual DateTime? UpdateDate { get; set; }

        public virtual UserInfo UserInfo { get; set; }

        public virtual UserGroup UserGroup { get; set; }

    }

}
