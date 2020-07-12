using Entities.Models;
using System.Collections.Generic;

namespace Contracts
{
  public interface IUserRepository : IRepositoryBase<User>
  {
    IEnumerable<User> RecuperarTodosUsuarios();
    User RecuperarUsuarioPorId(int id);
    User RecuperarUsuarioConDetalles(int id);
  }
}
