using System.Collections.Generic;

namespace Entities.DTO
{
  public class FavoritosDTO
  {
    public int ItemId { get; set; }
    public int AlbumId { get; set; }
    public string GustoName { get; set; }
    public IEnumerable<UserDTO> Users { get; set; }
  }
}
