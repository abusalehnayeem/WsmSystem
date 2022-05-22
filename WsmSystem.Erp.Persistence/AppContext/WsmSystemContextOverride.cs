using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using WsmSystem.Erp.Domain.Common;
using WsmSystem.Erp.Persistence.EntityConfigurations.V1.Securities;

namespace WsmSystem.Erp.Persistence.AppContext
{
    public partial class WsmSystemContext
    {
        public IDbContextTransaction CurrentTransaction { get; protected set; }
        public bool HasActiveTransaction => CurrentTransaction != null;

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.MakeBy = _currentUserService.IdUser;
                        entry.Entity.MakeDate = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.UpdateBy = _currentUserService.IdUser;
                        entry.Entity.UpdateDate = DateTime.Now;
                        break;
                }
            }
            return await base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Securities
            modelBuilder.ApplyConfiguration(new AppClientConfiguration());
            modelBuilder.ApplyConfiguration(new ClientInfoConfiguration());
            modelBuilder.ApplyConfiguration(new ModuleConfiguration());
            modelBuilder.ApplyConfiguration(new RoleWiseScreenPermissionConfiguration());
            modelBuilder.ApplyConfiguration(new ScreenConfiguration());
            modelBuilder.ApplyConfiguration(new SecurityPolicyConfiguration());
            modelBuilder.ApplyConfiguration(new SubModuleConfiguration());
            modelBuilder.ApplyConfiguration(new SubModuleSectionConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserInfoConfiguration());

            modelBuilder.ApplyConfiguration(new HttpRequestTypeConfiguration());
            modelBuilder.ApplyConfiguration(new UserGroupConfiguration());
            modelBuilder.ApplyConfiguration(new UserGroupRoleLinkConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleResourceLinkConfiguration());
            modelBuilder.ApplyConfiguration(new UserGroupLinkConfiguration());
            modelBuilder.ApplyConfiguration(new UserResourceConfiguration());
            #endregion
        }
    }
}
