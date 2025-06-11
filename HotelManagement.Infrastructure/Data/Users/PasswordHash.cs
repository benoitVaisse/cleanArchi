using HotelManagement.Domain.Users;
using Microsoft.AspNetCore.Identity;

namespace HotelManagement.Infrastructure.Data.Users;

public sealed class PasswordHash
{
    private static readonly PasswordHash _instance = new PasswordHash();
    public static PasswordHash Instance => _instance;

    public readonly IPasswordHasher<User> _passwordHasher = new PasswordHasher<User>();

    public PasswordHash()
    {
    }

    public string HashPassword(User user, string password)
    {
        return _passwordHasher.HashPassword(user, password);
    }

    public bool VerifyUserHash(User user, string passwordHash, string passwword)
    {
        var result = _passwordHasher.VerifyHashedPassword(user, passwordHash, passwword);
        return result != PasswordVerificationResult.Failed;
    }
}
