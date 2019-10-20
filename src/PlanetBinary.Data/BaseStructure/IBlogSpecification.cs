using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace PlanetBinary.Data.BaseStructure
{
	public interface IBlogSpecification<T>
	{
		Expression<Func<T, bool>> Criteria { get; }
		Func<IQueryable<T>, IIncludableQueryable<T, object>> Include { get; }
		Expression<Func<T, object>> OrderBy { get; }
		Expression<Func<T, object>> OrderByDescending { get; }

		int Take { get; }
		int Skip { get; }
		bool IsPagingEnabled { get; }
	}
}
