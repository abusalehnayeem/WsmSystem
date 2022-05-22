using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;
using WsmSystem.Erp.Domain.Entities.V1.Securities;

namespace WsmSystem.Erp.Contract
{
    public interface IWsmSystemContext
    {
        #region Core Operation Implementation
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess = false,
            CancellationToken cancellationToken = default);

        IDbContextTransaction CurrentTransaction { get; }
        public DatabaseFacade Database { get; }
        bool HasActiveTransaction { get; }
        //Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default);
        //Task<IDbContextTransaction> BeginTransactionAsync(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted, CancellationToken cancellationToken = default);
        //Task CommitTransactionAsync(IDbContextTransaction transaction, CancellationToken cancellationToken = default);
        //Task RollbackTransactionAsync(CancellationToken cancellationToken = default);

        EntityEntry Entry(object entity);
        EntityEntry Attach(object entity);


        #endregion
        #region Securities
        DbSet<AppClient> AppClients { get; set; }
        DbSet<ClientInfo> ClientInfos { get; set; }
        DbSet<HttpRequestType> HttpRequestTypes { get; set; }
        DbSet<Module> Modules { get; set; }
        DbSet<RoleWiseScreenPermission> RoleWiseScreenPermissions { get; set; }
        DbSet<Screen> Screens { get; set; }
        DbSet<SecurityPolicy> SecurityPolicies { get; set; }
        DbSet<SubModule> SubModules { get; set; }
        DbSet<SubModuleSection> SubModuleSections { get; set; }
        DbSet<UserGroupLink> UserGroupLinks { get; set; }
        DbSet<UserGroupRoleLink> UserGroupRoleLinks { get; set; }
        DbSet<UserGroup> UserGroups { get; set; }
        DbSet<UserInfo> UserInfos { get; set; }
        DbSet<UserResource> UserResources { get; set; }
        DbSet<UserRoleResourceLink> UserRoleResourceLinks { get; set; }
        DbSet<UserRole> UserRoles { get; set; }
        #endregion
    }
}
