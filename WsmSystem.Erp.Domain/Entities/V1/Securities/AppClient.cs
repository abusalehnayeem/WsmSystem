﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 5/22/2022 12:09:13 PM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using WsmSystem.Erp.Domain.Common;

namespace WsmSystem.Erp.Domain.Entities.V1.Securities
{
    public class AppClient : AuditableEntity
    {
        public AppClient() => ClientInfos = new List<ClientInfo>();

        public virtual int Id { get; set; }

        public virtual string AppClientName { get; set; }

        public virtual string ApplicationKey { get; set; }

        public virtual DateTime? ExpireDate { get; set; }

        public virtual bool IsActive { get; set; }

        public virtual string LastAction { get; set; }

        public virtual IList<ClientInfo> ClientInfos { get; set; }

    }

}
