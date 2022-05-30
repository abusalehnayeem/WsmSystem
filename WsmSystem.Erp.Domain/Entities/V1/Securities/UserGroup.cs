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
    public class UserGroup : BaseEntity
    {
        public UserGroup(int idClient, int id, string groupName, string? groupDescription, IList<UserGroupLink> userGroupLinks, IList<UserGroupRoleLink> userGroupRoleLinks)
        {
            IdClient = idClient;
            Id = id;
            GroupName = groupName ?? throw new ArgumentNullException(nameof(groupName));
            GroupDescription = groupDescription;
            UserGroupLinks = userGroupLinks ?? throw new ArgumentNullException(nameof(userGroupLinks));
            UserGroupRoleLinks = userGroupRoleLinks ?? throw new ArgumentNullException(nameof(userGroupRoleLinks));
        }

        public virtual int IdClient { get; set; }

        public virtual int Id { get; set; }

        public virtual string GroupName { get; set; }

        public virtual string? GroupDescription { get; set; }

        public virtual IList<UserGroupLink> UserGroupLinks { get; set; } = new List<UserGroupLink>();

        public virtual IList<UserGroupRoleLink> UserGroupRoleLinks { get; set; } = new List<UserGroupRoleLink>();
    }
}