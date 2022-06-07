﻿using Microsoft.EntityFrameworkCore;
using WsmSystem.Erp.Domain.NoNeedCodes.Interfaces;

namespace WsmSystem.Erp.Domain.Evaluators
{
#if !NETSTANDARD2_0

    public class AsSplitQueryEvaluator : IEvaluator
    {
        private AsSplitQueryEvaluator()
        { }

        public static AsSplitQueryEvaluator Instance { get; } = new AsSplitQueryEvaluator();

        public bool IsCriteriaEvaluator { get; } = true;

        public IQueryable<T> GetQuery<T>(IQueryable<T> query, ISpecification<T> specification) where T : class
        {
            if (specification.AsSplitQuery)
            {
                query = query.AsSplitQuery();
            }

            return query;
        }
    }

#endif
}