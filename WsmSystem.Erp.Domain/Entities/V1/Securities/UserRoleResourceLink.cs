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
    public class UserRoleResourceLink : BaseEntity
    {
        public UserRoleResourceLink(int idClient, int id, int idUserResource, int idUserRole, UserResource userResource, UserRole userRole)
        {
            IdClient = idClient;
            Id = id;
            IdUserResource = idUserResource;
            IdUserRole = idUserRole;
            UserResource = userResource ?? throw new ArgumentNullException(nameof(userResource));
            UserRole = userRole ?? throw new ArgumentNullException(nameof(userRole));
        }

        public virtual int IdClient { get; set; }

        public virtual int Id { get; set; }

        public virtual int IdUserResource { get; set; }

        public virtual int IdUserRole { get; set; }

        public virtual UserResource UserResource { get; set; }

        public virtual UserRole UserRole { get; set; }

    }

}
