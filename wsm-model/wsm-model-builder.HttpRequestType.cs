﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 5/22/2022 6:30:11 PM
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

namespace WsmSystem.Erp.Domain
{
    public  class HttpRequestType {

        public HttpRequestType()
        {
            UserResources = new List<UserResource>();
           
        }

        public virtual int IdClient { get; set; }

        public virtual int Id { get; set; }

        public virtual string HttpMethodType { get; set; }

        public virtual bool IsActive { get; set; }

        public virtual string LastAction { get; set; }

        public virtual string MakeBy { get; set; }

        public virtual DateTime MakeDate { get; set; }

        public virtual string UpdateBy { get; set; }

        public virtual DateTime? UpdateDate { get; set; }

        public virtual IList<UserResource> UserResources { get; set; }

    }

}
