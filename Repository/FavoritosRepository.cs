using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
  public class FavoritosRepository : RepositoryBase<Favoritos>, IFavoritosRepository
  {
    public FavoritosRepository(RepositoryContext repositoryContext)
      : base(repositoryContext) { }
  }
}
