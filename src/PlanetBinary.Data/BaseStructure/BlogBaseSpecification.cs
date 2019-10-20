﻿using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace PlanetBinary.Data.BaseStructure
{
	public abstract class BlogBaseSpecification<T> : IBlogSpecification<T>
	{
		protected BlogBaseSpecification()
		{
		}

		protected BlogBaseSpecification(Expression<Func<T, bool>> criteria)
		{
			Criteria = criteria;
		}

		public Expression<Func<T, bool>> Criteria { get; private set; }
		public Func<IQueryable<T>, IIncludableQueryable<T, object>> Include { get; private set; }
		public List<string> IncludeStrings { get; } = new List<string>();
		public Expression<Func<T, object>> OrderBy { get; private set; }
		public Expression<Func<T, object>> OrderByDescending { get; private set; }

		public int Take { get; private set; }
		public int Skip { get; private set; }
		public bool IsPagingEnabled { get; private set; } = false;

		public void UseCriteria(Expression<Func<T, bool>> criteria)
		{
			Criteria = criteria;
		}

		protected virtual void AddInclude(Func<IQueryable<T>, IIncludableQueryable<T, object>> includeExpression)
		{
			Include = includeExpression;
		}

		protected virtual void AddInclude(string includeString)
		{
			IncludeStrings.Add(includeString);
		}

		protected virtual void ApplyPaging(int skip, int take)
		{
			Skip = skip;
			Take = take;
			IsPagingEnabled = true;
		}

		protected virtual void ApplyOrderBy(Expression<Func<T, object>> orderByExpression)
		{
			OrderBy = orderByExpression;
		}

		protected virtual void ApplyOrderByDescending(Expression<Func<T, object>> orderByDescendingExpression)
		{
			OrderByDescending = orderByDescendingExpression;
		}
	}
}
