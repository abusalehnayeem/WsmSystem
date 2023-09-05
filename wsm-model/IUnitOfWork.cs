﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using the template for generating Repositories and a Unit of Work for EF Core model.
// Code is generated on: 7/21/2023 10:48:21 AM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
using System;

namespace WsmSystemModel
{
    public partial interface IUnitOfWork : IDisposable
    {
        IAppClientRepository AppClients { get; }
        IAppClientHistoryRepository AppClientHistories { get; }
        IBaseLanguageRepository BaseLanguages { get; }
        IBaseLanguageHistoryRepository BaseLanguageHistories { get; }
        IClientCompanyRepository ClientCompanies { get; }
        IClientCompanyHistoryRepository ClientCompanyHistories { get; }
        IEmailTemplateRepository EmailTemplates { get; }
        IEmailTemplateHistoryRepository EmailTemplateHistories { get; }
        IHttpMethodRepository HttpMethods { get; }
        IHttpMethodHistoryRepository HttpMethodHistories { get; }
        IModuleRepository Modules { get; }
        IModuleHistoryRepository ModuleHistories { get; }
        INoticeRepository Notices { get; }
        INoticeHistoryRepository NoticeHistories { get; }
        IPermissionNamingPolicyRepository PermissionNamingPolicies { get; }
        IPermissionNamingPolicyHistoryRepository PermissionNamingPolicyHistories { get; }
        IPhraseTagRepository PhraseTags { get; }
        IPhraseTagHistoryRepository PhraseTagHistories { get; }
        IPhraseTagTranslationRepository PhraseTagTranslations { get; }
        IPhraseTagTranslationHistoryRepository PhraseTagTranslationHistories { get; }
        IRoleScreenLinkRepository RoleScreenLinks { get; }
        IRoleScreenLinkHistoryRepository RoleScreenLinkHistories { get; }
        IScreenRepository Screens { get; }
        IScreenHistoryRepository ScreenHistories { get; }
        ISectionRepository Sections { get; }
        ISectionHistoryRepository SectionHistories { get; }
        ISmtpClientRepository SmtpClients { get; }
        ISmtpClientHistoryRepository SmtpClientHistories { get; }
        ISubModuleRepository SubModules { get; }
        ISubModuleHistoryRepository SubModuleHistories { get; }
        IUserGroupRepository UserGroups { get; }
        IUserGroupHistoryRepository UserGroupHistories { get; }
        IUserGroupWiseRoleMappingRepository UserGroupWiseRoleMappings { get; }
        IUserGroupWiseRoleMappingHistoryRepository UserGroupWiseRoleMappingHistories { get; }
        IUserResourceRepository UserResources { get; }
        IUserResourceHistoryRepository UserResourceHistories { get; }
        IUserRoleRepository UserRoles { get; }
        IUserRoleHistoryRepository UserRoleHistories { get; }
        IUserRoleWiseResourceMappingRepository UserRoleWiseResourceMappings { get; }
        IUserRoleWiseResourceMappingHistoryRepository UserRoleWiseResourceMappingHistories { get; }
        IUserRepository Users { get; }
        IUsersHistoryRepository UsersHistories { get; }
        IUserWiseGroupMappingRepository UserWiseGroupMappings { get; }
        IUserWiseGroupMappingHistoryRepository UserWiseGroupMappingHistories { get; }
        void Save();
    }
}