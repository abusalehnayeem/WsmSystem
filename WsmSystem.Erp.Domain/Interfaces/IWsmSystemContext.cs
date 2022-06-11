using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using WsmSystem.Erp.Domain.Entities.V1.Securities;

namespace WsmSystem.Erp.Domain.Interfaces
{
    public interface IWsmSystemContext
    {
        #region Core Operation Implementation

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess = false,
            CancellationToken cancellationToken = default);

        public DatabaseFacade Database { get; }
        bool HasActiveTransaction { get; }

        Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default);

        Task CommitTransactionAsync(IDbContextTransaction transaction, CancellationToken cancellationToken = default);

        Task RollbackTransactionAsync(CancellationToken cancellationToken = default);

        EntityEntry Entry(object entity);

        EntityEntry Attach(object entity);

        #endregion Core Operation Implementation

        #region Securities

        DbSet<AppClient> AppClients { get; }
        DbSet<ClientInfo> ClientInfos { get; }
        DbSet<HttpRequestType> HttpRequestTypes { get; }
        DbSet<Module> Modules { get; }
        DbSet<RoleWiseScreenPermission> RoleWiseScreenPermissions { get; }
        DbSet<Screen> Screens { get; }
        DbSet<SecurityPolicy> SecurityPolicies { get; }
        DbSet<SubModule> SubModules { get; }
        DbSet<SubModuleSection> SubModuleSections { get; }
        DbSet<UserGroupLink> UserGroupLinks { get; }
        DbSet<UserGroupRoleLink> UserGroupRoleLinks { get; }
        DbSet<UserGroup> UserGroups { get; }
        DbSet<UserInfo> UserInfos { get; }
        DbSet<UserResource> UserResources { get; }
        DbSet<UserRoleResourceLink> UserRoleResourceLinks { get; }
        DbSet<UserRole> UserRoles { get; }

        #endregion Securities
    }
}
