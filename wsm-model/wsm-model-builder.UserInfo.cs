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
    public  class UserInfo {

        public UserInfo()
        {
            UserGroupLinks = new List<UserGroupLink>();
           
        }

        public virtual int IdClient { get; set; }

        public virtual int Id { get; set; }

        public virtual string? AccessLevel { get; set; }

        public virtual string UserName { get; set; }

        public virtual string? UserFullName { get; set; }

        public virtual string UserPassword { get; set; }

        public virtual string? PasswordSalt { get; set; }

        public virtual int? IdRole { get; set; }

        public virtual bool IsActive { get; set; }

        public virtual string? UserEmail { get; set; }

        public virtual bool IsLockedOut { get; set; }

        public virtual bool? ChangePassword { get; set; }

        public virtual string LastAction { get; set; }

        public virtual string MakeBy { get; set; }

        public virtual DateTime MakeDate { get; set; }

        public virtual string? UpdateBy { get; set; }

        public virtual DateTime? UpdateDate { get; set; }

        public virtual IList<UserGroupLink> UserGroupLinks { get; set; }

        public virtual UserRole UserRole { get; set; }

    }

}
