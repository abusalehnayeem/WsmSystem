using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WsmSystem.Erp.Domain.Specifications;

namespace WsmSystem.Erp.Persistence.Repositories
{
    public class Repository<T> : BaseRepository<T>, IRepository<T> where T : BaseEntity
    {
        private readonly IWsmSystemContext _context;

        public Repository(IWsmSystemContext context) : base((DbContext)context) => _context = context;
    }
}
