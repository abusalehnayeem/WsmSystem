using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WsmSystem.Erp.SharedKarnel
{
    public interface IEvaluator<T> where T : BaseEntity
    {
        bool IsCriteriaEvaluator { get; }
        IQueryable<T> GetQuery(IQueryable<T> query, ISpecification<T> specification);
    }
}
