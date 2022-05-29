namespace WsmSystem.Erp.Persistence.AppContext
{
    public partial class WsmSystemContext
    {
        #region Securities

        public virtual DbSet<AppClient> AppClients => Set<AppClient>();

        public virtual DbSet<ClientInfo> ClientInfos => Set<ClientInfo>();

        public virtual DbSet<HttpRequestType> HttpRequestTypes => Set<HttpRequestType>();

        public virtual DbSet<Module> Modules => Set<Module>();

        public virtual DbSet<RoleWiseScreenPermission> RoleWiseScreenPermissions => Set<RoleWiseScreenPermission>();

        public virtual DbSet<Screen> Screens => Set<Screen>();

        public virtual DbSet<SecurityPolicy> SecurityPolicies => Set<SecurityPolicy>();

        public virtual DbSet<SubModule> SubModules => Set<SubModule>();

        public virtual DbSet<SubModuleSection> SubModuleSections => Set<SubModuleSection>();

        public virtual DbSet<UserGroup> UserGroups => Set<UserGroup>();

        public virtual DbSet<UserGroupLink> UserGroupLinks => Set<UserGroupLink>();

        public virtual DbSet<UserGroupRoleLink> UserGroupRoleLinks => Set<UserGroupRoleLink>();

        public virtual DbSet<UserInfo> UserInfos => Set<UserInfo>();

        public virtual DbSet<UserResource> UserResources => Set<UserResource>();

        public virtual DbSet<UserRole> UserRoles => Set<UserRole>();
        public virtual DbSet<UserRoleResourceLink> UserRoleResourceLinks => Set<UserRoleResourceLink>();

        #endregion Securities
    }
}