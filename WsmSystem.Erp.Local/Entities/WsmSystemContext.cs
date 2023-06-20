
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using WsmSystem.Erp.Local.Entities.Configurations;
namespace WsmSystem.Erp.Local.Entities;

public partial class WsmSystemContext : DbContext
{
    public WsmSystemContext(DbContextOptions<WsmSystemContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AppClient> AppClient { get; set; }

    public virtual DbSet<BaseLanguage> BaseLanguage { get; set; }

    public virtual DbSet<ClientCompany> ClientCompany { get; set; }

    public virtual DbSet<EmailTemplate> EmailTemplate { get; set; }

    public virtual DbSet<HttpMethod> HttpMethod { get; set; }

    public virtual DbSet<Module> Module { get; set; }

    public virtual DbSet<Notice> Notice { get; set; }

    public virtual DbSet<PermissionNamingPolicy> PermissionNamingPolicy { get; set; }

    public virtual DbSet<PhraseTag> PhraseTag { get; set; }

    public virtual DbSet<PhraseTagTranslation> PhraseTagTranslation { get; set; }

    public virtual DbSet<RoleScreenLink> RoleScreenLink { get; set; }

    public virtual DbSet<Screen> Screen { get; set; }

    public virtual DbSet<Section> Section { get; set; }

    public virtual DbSet<SmtpClient> SmtpClient { get; set; }

    public virtual DbSet<SubModule> SubModule { get; set; }

    public virtual DbSet<UserGroup> UserGroup { get; set; }

    public virtual DbSet<UserGroupWiseRoleMapping> UserGroupWiseRoleMapping { get; set; }

    public virtual DbSet<UserResource> UserResource { get; set; }

    public virtual DbSet<UserRole> UserRole { get; set; }

    public virtual DbSet<UserRoleWiseResourceMapping> UserRoleWiseResourceMapping { get; set; }

    public virtual DbSet<UserWiseGroupMapping> UserWiseGroupMapping { get; set; }

    public virtual DbSet<Users> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
            modelBuilder.ApplyConfiguration(new Configurations.AppClientConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.BaseLanguageConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.ClientCompanyConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.EmailTemplateConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.HttpMethodConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.ModuleConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.NoticeConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.PermissionNamingPolicyConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.PhraseTagConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.PhraseTagTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.RoleScreenLinkConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.ScreenConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.SectionConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.SmtpClientConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.SubModuleConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.UserGroupConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.UserGroupWiseRoleMappingConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.UserResourceConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.UserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.UserRoleWiseResourceMappingConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.UserWiseGroupMappingConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.UsersConfiguration());

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
