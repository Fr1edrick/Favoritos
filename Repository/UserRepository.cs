using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
  public class UserRepository : RepositoryBase<User>, IUserRepository
  {
    public UserRepository(RepositoryContext repositoryContext)
      : base(repositoryContext) { }

    public IEnumerable<User> RecuperarTodosUsuarios()
    {
      return BuscarTodos()
        .OrderBy(u => u.UserId)
        .ToList();
    }

    public User RecuperarUsuarioConDetalles(int id)
    {
      return BuscarConCondicion(u => u.UserId.Equals(id))
        .Include(fav => fav.Favoritos.Equals(id))
        .FirstOrDefault();
    }

    public User RecuperarUsuarioPorId(int id)
    {
      return BuscarConCondicion(u => u.UserId.Equals(id))
        .FirstOrDefault();
    }
  }
}
