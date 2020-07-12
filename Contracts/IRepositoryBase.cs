using System;
using System.Linq;
using System.Linq.Expressions;

namespace Contracts
{
  public interface IRepositoryBase<T>
  {
    IQueryable<T> BuscarTodos();
    IQueryable<T> BuscarConCondicion(Expression<Func<T, bool>> expression);
    void Create(T Entity);
    void Update(T Entity);
    void Delete(T Entity);
  }
}
