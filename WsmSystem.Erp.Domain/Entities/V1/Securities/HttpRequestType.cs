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
    public class HttpRequestType : BaseEntity
    {
        public HttpRequestType(int idClient, int id, string httpMethodType, bool isActive, IList<UserResource> userResources)
        {
            IdClient = idClient;
            Id = id;
            HttpMethodType = httpMethodType ?? throw new ArgumentNullException(nameof(httpMethodType));
            IsActive = isActive;
            UserResources = userResources ?? throw new ArgumentNullException(nameof(UserResources));
        }

        public virtual int IdClient { get; set; }

        public virtual int Id { get; set; }

        public virtual string HttpMethodType { get; set; }

        public virtual IList<UserResource> UserResources { get; set; } = new List<UserResource>();

    }

}
