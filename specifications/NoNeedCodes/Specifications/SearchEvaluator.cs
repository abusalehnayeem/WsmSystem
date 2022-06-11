﻿using WsmSystem.Erp.Domain.NoNeedCodes.Interfaces;

namespace WsmSystem.Erp.Domain.NoNeedCodes.Specifications
{
    public class SearchEvaluator : IInMemoryEvaluator
    {
        private SearchEvaluator()
        { }

        public static SearchEvaluator Instance { get; } = new SearchEvaluator();

        public IEnumerable<T> Evaluate<T>(IEnumerable<T> query, ISpecification<T> specification)
        {
            foreach (var searchGroup in specification.SearchCriterias.GroupBy(x => x.SearchGroup))
            {
                query = query.Where(x => searchGroup.Any(c => c.SelectorFunc(x).Like(c.SearchTerm)));
            }

            return query;
        }
    }
}