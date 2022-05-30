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
    public class Module : BaseEntity
    {
        public Module(int idClient, int id, string? moduleName, string? iconName, IList<SubModule> subModules)
        {
            IdClient = idClient;
            Id = id;
            ModuleName = moduleName;
            IconName = iconName;
            SubModules = subModules ?? throw new ArgumentNullException(nameof(subModules));
        }

        public virtual int IdClient { get; set; }

        public virtual int Id { get; set; }

        public virtual string? ModuleName { get; set; }

        public virtual string? IconName { get; set; }

        public virtual IList<SubModule> SubModules { get; set; } = new List<SubModule>();
    }
}