namespace WsmSystem.Erp.Persistence.UnitOfWorks
{
    public partial class UnitOfWork : IUnitOfWork
    {
        private readonly IWsmSystemContext _context;

        public UnitOfWork(IWsmSystemContext context) => _context = context;

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken) => _context.SaveChangesAsync(cancellationToken);
    }
}
