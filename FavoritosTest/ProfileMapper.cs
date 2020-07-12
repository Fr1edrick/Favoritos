using AutoMapper;
using Entities.DTO;
using Entities.Models;

namespace FavoritosTest
{
  public class ProfileMapper : Profile
  {
    public ProfileMapper()
    {
      CreateMap<User, UserDTO>();
      CreateMap<Favoritos, FavoritosDTO>();
    }

  }
}
