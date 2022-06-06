using WsmSystem.Erp.Domain.Interfaces;

namespace WsmSystem.Erp.Persistence.Specifications
{
    public class SpecificationEvaluator<TEntity> : IEvaluator<TEntity> where TEntity : class
    {
        public bool IsCriteriaEvaluator { get; } = false;

        public IQueryable<TEntity> GetQuery(IQueryable<TEntity> query, ISpecification<TEntity> specification)
        {
            var inputQuery = query;

            // modify the IQueryable using the specification's criteria expression
            if (specification.Criteria != null)
            {
                inputQuery = inputQuery.Where(specification.Criteria);
            }

            // Includes all expression-based includes
            inputQuery = specification.Includes.Aggregate(inputQuery, (current, include) => current.Include(include));
            // Include any string-based include statements
            inputQuery = specification.IncludeStrings.Aggregate(inputQuery, (current, include) => current.Include(include));

            // Apply ordering if expressions are set
            if (specification.OrderBy != null)
            {
                inputQuery = inputQuery.OrderBy(specification.OrderBy);
            }
            else if (specification.OrderByDescending != null)
            {
                inputQuery = inputQuery.OrderByDescending(specification.OrderByDescending);
            }

            if (specification.GroupBy != null)
            {
                inputQuery = inputQuery.GroupBy(specification.GroupBy).SelectMany(x => x);
            }

            // Apply paging if enabled
            if (specification.IsPagingEnabled)
            {
                inputQuery = inputQuery.Skip(specification.Skip).Take(specification.Take);
            }
            return inputQuery;
        }
    }
}
