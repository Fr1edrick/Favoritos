using Contracts;
using Entities;

namespace Repository
{
  public class RepositoryWrapper : IRepositoryWrapper
  {
    private RepositoryContext _repoContext;
    private IUserRepository _userRepo;
    private IFavoritosRepository _favoritosRepo;

    public RepositoryWrapper(RepositoryContext repositoryContext)
    {
      _repoContext = repositoryContext;
    }

    public IUserRepository _user
    {
      get
      {
        if (_userRepo == null)
        {
          _userRepo = new UserRepository(_repoContext);
        }
        return _userRepo;
      }
    }

    public IFavoritosRepository Favoritos
    {
      get
      {
        if (_favoritosRepo == null)
        {
          _favoritosRepo = new FavoritosRepository(_repoContext);
        }
        return _favoritosRepo;
      }
    }

    public void Save()
    {
      _repoContext.SaveChanges();
    }
  }
}
