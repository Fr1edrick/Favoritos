using Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Repository
{
  public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
  {
    protected RepositoryContext RepositoryContext { get; }

    public RepositoryBase(RepositoryContext repositoryContext)
    {
      RepositoryContext = repositoryContext;
    }

    public IQueryable<T> BuscarTodos()
    {
      return RepositoryContext.Set<T>().AsNoTracking();
    }

    public IQueryable<T> BuscarConCondicion(Expression<Func<T, bool>> expression)
    {
      return RepositoryContext.Set<T>().Where(expression).AsNoTracking();
    }

    public void Create(T Entity)
    {
      RepositoryContext.Set<T>().Add(Entity);
    }

    public void Update(T Entity)
    {
      RepositoryContext.Set<T>().Update(Entity);
    }

    public void Delete(T Entity)
    {
      RepositoryContext.Set<T>().Remove(Entity);
    }
  }
}
