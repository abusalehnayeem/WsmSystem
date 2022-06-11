namespace WsmSystem.Erp.Persistence.Repositories
{
    public class Repository<T> : BaseRepository<T>, IRepository<T> where T : BaseEntity
    {
        private readonly IWsmSystemContext _context;

        public Repository(IWsmSystemContext context) : base((DbContext)context) => _context = context;
    }
}
