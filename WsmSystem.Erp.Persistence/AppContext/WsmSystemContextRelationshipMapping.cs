namespace WsmSystem.Erp.Persistence.AppContext
{
    public partial class WsmSystemContext
    {
        private static void RelationshipsMapping(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppClient>().HasMany(x => x.ClientInfos).WithOne(op => op.AppClient).HasForeignKey(@"IdAppClient").IsRequired(true);

            modelBuilder.Entity<ClientInfo>().HasOne(x => x.AppClient).WithMany(op => op.ClientInfos).HasForeignKey(@"IdAppClient").IsRequired(true);

            modelBuilder.Entity<HttpRequestType>().HasMany(x => x.UserResources).WithOne(op => op.HttpRequestType).HasForeignKey(@"IdClient", @"IdHttpMethod").IsRequired(true);

            modelBuilder.Entity<Module>().HasMany(x => x.SubModules).WithOne(op => op.Module).HasForeignKey(@"IdClient", @"IdModule").IsRequired(true);

            modelBuilder.Entity<RoleWiseScreenPermission>().HasOne(x => x.Screen).WithMany(op => op.RoleWiseScreenPermissions).HasForeignKey(@"IdClient", @"ScreenCode").IsRequired(true);
            modelBuilder.Entity<RoleWiseScreenPermission>().HasOne(x => x.UserRole).WithMany(op => op.RoleWiseScreenPermissions).HasForeignKey(@"IdClient", @"IdRole").IsRequired(true);

            modelBuilder.Entity<Screen>().HasMany(x => x.RoleWiseScreenPermissions).WithOne(op => op.Screen).HasForeignKey(@"IdClient", @"ScreenCode").IsRequired(true);
            modelBuilder.Entity<Screen>().HasOne(x => x.SubModuleSection).WithMany(op => op.Screens).HasForeignKey(@"IdClient", @"IdSubModuleSection", @"IdModule", @"IdSubModule").IsRequired(true);

            modelBuilder.Entity<SubModule>().HasOne(x => x.Module).WithMany(op => op.SubModules).HasForeignKey(@"IdClient", @"IdModule").IsRequired(true);
            modelBuilder.Entity<SubModule>().HasMany(x => x.SubModuleSections).WithOne(op => op.SubModule).HasForeignKey(@"IdClient", @"IdSubModule", @"IdModule").IsRequired(true);

            modelBuilder.Entity<SubModuleSection>().HasMany(x => x.Screens).WithOne(op => op.SubModuleSection).HasForeignKey(@"IdClient", @"IdSubModuleSection", @"IdModule", @"IdSubModule").IsRequired(true);
            modelBuilder.Entity<SubModuleSection>().HasOne(x => x.SubModule).WithMany(op => op.SubModuleSections).HasForeignKey(@"IdClient", @"IdSubModule", @"IdModule").IsRequired(true);

            modelBuilder.Entity<UserGroup>().HasMany(x => x.UserGroupLinks).WithOne(op => op.UserGroup).HasForeignKey(@"IdClient", @"IdUserGroup").IsRequired(true);
            modelBuilder.Entity<UserGroup>().HasMany(x => x.UserGroupRoleLinks).WithOne(op => op.UserGroup).HasForeignKey(@"IdClient", @"IdUserGroup").IsRequired(true);

            modelBuilder.Entity<UserGroupLink>().HasOne(x => x.UserInfo).WithMany(op => op.UserGroupLinks).HasForeignKey(@"IdClient", @"IdUser").IsRequired(true);
            modelBuilder.Entity<UserGroupLink>().HasOne(x => x.UserGroup).WithMany(op => op.UserGroupLinks).HasForeignKey(@"IdClient", @"IdUserGroup").IsRequired(true);

            modelBuilder.Entity<UserGroupRoleLink>().HasOne(x => x.UserGroup).WithMany(op => op.UserGroupRoleLinks).HasForeignKey(@"IdClient", @"IdUserGroup").IsRequired(true);
            modelBuilder.Entity<UserGroupRoleLink>().HasOne(x => x.UserRole).WithMany(op => op.UserGroupRoleLinks).HasForeignKey(@"IdClient", @"IdUserRole").IsRequired(true);

            modelBuilder.Entity<UserInfo>().HasMany(x => x.UserGroupLinks).WithOne(op => op.UserInfo).HasForeignKey(@"IdClient", @"IdUser").IsRequired(true);
            modelBuilder.Entity<UserInfo>().HasOne(x => x.UserRole).WithMany(op => op.UserInfos).HasForeignKey(@"IdClient", @"IdRole").IsRequired(false);

            modelBuilder.Entity<UserResource>().HasOne(x => x.HttpRequestType).WithMany(op => op.UserResources).HasForeignKey(@"IdClient", @"IdHttpMethod").IsRequired(true);
            modelBuilder.Entity<UserResource>().HasMany(x => x.UserRoleResourceLinks).WithOne(op => op.UserResource).HasForeignKey(@"IdClient", @"IdUserResource").IsRequired(true);

            modelBuilder.Entity<UserRole>().HasMany(x => x.RoleWiseScreenPermissions).WithOne(op => op.UserRole).HasForeignKey(@"IdClient", @"IdRole").IsRequired(true);
            modelBuilder.Entity<UserRole>().HasMany(x => x.UserGroupRoleLinks).WithOne(op => op.UserRole).HasForeignKey(@"IdClient", @"IdUserRole").IsRequired(true);
            modelBuilder.Entity<UserRole>().HasMany(x => x.UserInfos).WithOne(op => op.UserRole).HasForeignKey(@"IdClient", @"IdRole").IsRequired(false);
            modelBuilder.Entity<UserRole>().HasMany(x => x.UserRoleResourceLinks).WithOne(op => op.UserRole).HasForeignKey(@"IdClient", @"IdUserRole").IsRequired(true);

            modelBuilder.Entity<UserRoleResourceLink>().HasOne(x => x.UserResource).WithMany(op => op.UserRoleResourceLinks).HasForeignKey(@"IdClient", @"IdUserResource").IsRequired(true);
            modelBuilder.Entity<UserRoleResourceLink>().HasOne(x => x.UserRole).WithMany(op => op.UserRoleResourceLinks).HasForeignKey(@"IdClient", @"IdUserRole").IsRequired(true);
        }
    }
}
