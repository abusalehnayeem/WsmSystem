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
    public class UserResource : BaseEntity
    {
        public virtual int IdClient { get; set; }

        public virtual int Id { get; set; }

        public virtual string ApiUrl { get; set; } = null!;

        public virtual int IdHttpMethod { get; set; }

        public virtual HttpRequestType HttpRequestType { get; set; } = null!;

        public virtual IList<UserRoleResourceLink> UserRoleResourceLinks { get; set; } = new List<UserRoleResourceLink>();
    }
}
