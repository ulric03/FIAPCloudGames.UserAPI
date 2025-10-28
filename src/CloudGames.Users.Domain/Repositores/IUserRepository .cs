using CloudGames.Users.Domain.Entities;

namespace CloudGames.Users.Domain.Repositores;

public interface IUserRepository : IBaseRepository<User>
{
    Task<User?> Login(string email, string password);
}
