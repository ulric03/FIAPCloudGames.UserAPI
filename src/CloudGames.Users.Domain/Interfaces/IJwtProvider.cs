namespace CloudGames.Users.Domain.Interfaces;

public interface IJwtProvider
{
    string GenerateToken(string userName, string role);
}
