namespace Contracts
{
  public interface IRepositoryWrapper
  {
    IUserRepository _user { get; }
    IFavoritosRepository Favoritos { get; }
    void Save();
  }
}
