using System.Collections.Generic;

namespace Entities.DTO
{
  public class UserDTO
  {
    public int UserId { get; set; }
    public string Nombre { get; set; }

    public IEnumerable<FavoritosDTO> Favoritos { get; set; }
  }
}
