using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlanetBinary.Data.BaseStructure
{
	public interface IBlogRepository<T> where T : class
	{
		T Get(object key);

		T Get(Expression<Func<T, bool>> condition);

		IQueryable<T> GetAsQueryable();

		IReadOnlyList<T> Get(bool asNoTracking = true);

		IReadOnlyList<T> Get(IBlogSpecification<T> spec, bool asNoTracking = true);

		T GetFirstOrDefault(IBlogSpecification<T> spec, bool asNoTracking = true);

		IReadOnlyList<TResult> Select<TResult>(Expression<Func<T, TResult>> selector, bool asNoTracking = true);

		IReadOnlyList<TResult> Select<TResult>(IBlogSpecification<T> spec, Expression<Func<T, TResult>> selector, bool asNoTracking = true);

		TResult SelectFirstOrDefault<TResult>(IBlogSpecification<T> spec, Expression<Func<T, TResult>> selector, bool asNoTracking = true);

		IReadOnlyList<TResult> Select<TGroup, TResult>(
			Expression<Func<T, TGroup>> groupExpression,
			Expression<Func<IGrouping<TGroup, T>, TResult>> selector,
			bool asNoTracking = true);

		T Add(T entity);

		int Update(T entity);

		int Delete(T entity);

		int Delete(object key);

		int Delete(IEnumerable<T> entities);

		int Count(IBlogSpecification<T> spec);

		int Count(Expression<Func<T, bool>> condition);

		bool Any(Expression<Func<T, bool>> condition = null);

		ValueTask<T> GetAsync(object key);

		Task<T> GetAsync(Expression<Func<T, bool>> condition);

		Task<IReadOnlyList<T>> GetAsync(bool asNoTracking = true);

		Task<IReadOnlyList<T>> GetAsync(IBlogSpecification<T> spec, bool asNoTracking = true);

		Task<T> GetFirstOrDefaultAsync(IBlogSpecification<T> spec, bool asNoTracking = true);

		Task<IReadOnlyList<TResult>> SelectAsync<TResult>(Expression<Func<T, TResult>> selector, bool asNoTracking = true);

		Task<IReadOnlyList<TResult>> SelectAsync<TResult>(IBlogSpecification<T> spec, Expression<Func<T, TResult>> selector, bool asNoTracking = true);

		Task<TResult> SelectFirstOrDefaultAsync<TResult>(IBlogSpecification<T> spec, Expression<Func<T, TResult>> selector, bool asNoTracking = true);

		Task<IReadOnlyList<TResult>> SelectAsync<TGroup, TResult>(
			Expression<Func<T, TGroup>> groupExpression,
			Expression<Func<IGrouping<TGroup, T>, TResult>> selector,
			bool asNoTracking = true);

		Task<IReadOnlyList<TResult>> SelectAsync<TGroup, TResult>(
			IBlogSpecification<T> spec,
			Expression<Func<T, TGroup>> groupExpression,
			Expression<Func<IGrouping<TGroup, T>, TResult>> selector,
			bool asNoTracking = true);

		Task<T> AddAsync(T entity);

		Task UpdateAsync(T entity);

		Task DeleteAsync(T entity);

		Task DeleteAsync(IEnumerable<T> entities);

		Task DeleteAsync(object key);

		Task<int> CountAsync(IBlogSpecification<T> spec);
	}
}
