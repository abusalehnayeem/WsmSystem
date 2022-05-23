using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using WsmSystem.Erp.Contract;
using WsmSystem.Erp.Domain.Common;
using WsmSystem.Erp.Persistence.EntityConfigurations.V1.Securities;

namespace WsmSystem.Erp.Persistence.AppContext
{
    public partial class WsmSystemContext: IWsmSystemContext
    {
        public IDbContextTransaction CurrentTransaction { get; private set; }
        public bool HasActiveTransaction => CurrentTransaction != null;

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

            #region Relationship Mappings

            RelationshipsMapping(modelBuilder);

            #endregion

            base.OnModelCreating(modelBuilder);
        }

        #region Core Operation Implementation
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

        public async Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default)
        {
            if (CurrentTransaction != null)
            {
                CurrentTransaction.Dispose();
            }
            return CurrentTransaction = await Database.BeginTransactionAsync(IsolationLevel.ReadCommitted, cancellationToken);
        }

        public Task CommitTransactionAsync(IDbContextTransaction transaction, CancellationToken cancellationToken = default)
        {
            if (transaction == null)
                throw new ArgumentNullException(nameof(transaction));
            if (transaction != CurrentTransaction)
                throw new InvalidOperationException($"Transaction {transaction.TransactionId} is not current");
            return InternalCommitTransactionAsync(transaction, cancellationToken);
        }

        private async Task InternalCommitTransactionAsync(IDbContextTransaction transaction, CancellationToken cancellationToken = default)
        {
            try
            {
                await transaction.CommitAsync(cancellationToken);
            }
            catch
            {
                await RollbackTransactionAsync(cancellationToken);
            }
            finally
            {
                if (CurrentTransaction != null)
                {
                    CurrentTransaction.Dispose();
                }
            }
        }

        public async Task RollbackTransactionAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                if (CurrentTransaction != null)
                {
                    await CurrentTransaction.RollbackAsync(cancellationToken);
                }
            }
            finally
            {
                if (CurrentTransaction != null)
                {
                    CurrentTransaction.Dispose();
                }
            }
        }
        #endregion
    }
}
