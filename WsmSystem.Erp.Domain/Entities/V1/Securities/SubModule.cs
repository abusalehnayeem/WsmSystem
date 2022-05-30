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
    public class SubModule : BaseEntity
    {
        public SubModule(int idClient, int id, int idModule, string subModuleName, string? iconName, short? ordinal, Module module, IList<SubModuleSection> subModuleSections)
        {
            IdClient = idClient;
            Id = id;
            IdModule = idModule;
            SubModuleName = subModuleName ?? throw new ArgumentNullException(nameof(subModuleName));
            IconName = iconName;
            Ordinal = ordinal;
            Module = module ?? throw new ArgumentNullException(nameof(module));
            SubModuleSections = subModuleSections ?? throw new ArgumentNullException(nameof(subModuleSections));
        }

        public virtual int IdClient { get; set; }

        public virtual int Id { get; set; }

        public virtual int IdModule { get; set; }

        public virtual string SubModuleName { get; set; }

        public virtual string? IconName { get; set; }

        public virtual short? Ordinal { get; set; }

        public virtual Module Module { get; set; }

        public virtual IList<SubModuleSection> SubModuleSections { get; set; } = new List<SubModuleSection>();
    }
}