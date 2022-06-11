﻿using Microsoft.EntityFrameworkCore;

namespace WsmSystem.Erp.Domain.Specifications
{
    public class SpecificationEvaluator : ISpecificationEvaluator
    {
        private SpecificationEvaluator() { }
        public static SpecificationEvaluator Default { get; } = new SpecificationEvaluator();
        public IQueryable<T> GetQuery<T>(IQueryable<T> inputQuery, ISpecification<T>? specification = null) where T : BaseEntity
        {
            var query = inputQuery;

            if (specification == null) return query;
            // modify the IQueryable using the specification's criteria expression
            if (specification.Criteria != null)
            {
                query = query.Where(specification.Criteria);
            }

            // Includes all expression-based includes
            query = specification.Includes.Aggregate(query,
                                    (current, include) => current.Include(include));

            // Include any string-based include statements
            query = specification.IncludeStrings.Aggregate(query,
                                    (current, include) => current.Include(include));

            // Apply ordering if expressions are set
            if (specification.OrderBy != null)
            {
                query = query.OrderBy(specification.OrderBy);
            }
            else if (specification.OrderByDescending != null)
            {
                query = query.OrderByDescending(specification.OrderByDescending);
            }

            if (specification.GroupBy != null)
            {
                query = query.GroupBy(specification.GroupBy).SelectMany(x => x);
            }

            // Apply paging if enabled
            if (specification.IsPagingEnabled)
            {
                query = query.Skip(specification.Skip)
                             .Take(specification.Take);
            }
            return query;
        }
    }
}