using Microsoft.EntityFrameworkCore;
using WsmSystem.Erp.Contract;
using WsmSystem.Erp.Domain.Entities.V1.Securities;

namespace WsmSystem.Erp.Persistence.AppContext
{

    public partial class WsmSystemContext
    {
        #region private variable

        private readonly ICurrentUserService _currentUserService;

        #endregion

        #region Securities
        public virtual DbSet<AppClient> AppClients { get; set; }

        public virtual DbSet<ClientInfo> ClientInfos { get; set; }

        public virtual DbSet<HttpRequestType> HttpRequestTypes { get; set; }

        public virtual DbSet<Module> Modules { get; set; }

        public virtual DbSet<RoleWiseScreenPermission> RoleWiseScreenPermissions { get; set; }

        public virtual DbSet<Screen> Screens { get; set; }

        public virtual DbSet<SecurityPolicy> SecurityPolicies { get; set; }

        public virtual DbSet<SubModule> SubModules { get; set; }

        public virtual DbSet<SubModuleSection> SubModuleSections { get; set; }

        public virtual DbSet<UserGroup> UserGroups { get; set; }

        public virtual DbSet<UserGroupLink> UserGroupLinks { get; set; }

        public virtual DbSet<UserGroupRoleLink> UserGroupRoleLinks { get; set; }

        public virtual DbSet<UserInfo> UserInfos { get; set; }

        public virtual DbSet<UserResource> UserResources { get; set; }

        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<UserRoleResourceLink> UserRoleResourceLinks { get; set; }
        #endregion
    }
}
