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
    public class SubModuleSection : BaseEntity
    {
        public SubModuleSection(int idClient, int id, int idModule, int idSubModule, string? sectionName, string? iconName, IList<Screen> screens, SubModule subModule)
        {
            IdClient = idClient;
            Id = id;
            IdModule = idModule;
            IdSubModule = idSubModule;
            SectionName = sectionName;
            IconName = iconName;
            Screens = screens ?? throw new ArgumentNullException(nameof(screens));
            SubModule = subModule ?? throw new ArgumentNullException(nameof(subModule));
        }

        public virtual int IdClient { get; set; }

        public virtual int Id { get; set; }

        public virtual int IdModule { get; set; }

        public virtual int IdSubModule { get; set; }

        public virtual string? SectionName { get; set; }

        public virtual string? IconName { get; set; }

        public virtual IList<Screen> Screens { get; set; } = new List<Screen>();

        public virtual SubModule SubModule { get; set; }
    }
}