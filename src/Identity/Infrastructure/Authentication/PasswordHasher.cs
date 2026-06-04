using System.Security.Cryptography;

namespace Identity.Infrastructure.Authentication;

public class PasswordHasher
{
    private const int SaltSize = 16;
    private const int HashSize = 32;
    private const int Iterations = 10000;

    public string HashPassword(string password)
    {
        if (string.IsNullOrWhiteSpace(password))
            throw new ArgumentException("Password cannot be null or empty.", nameof(password));

        using var algorithm = new Rfc2898DeriveBytes(
            password,
            SaltSize,
            Iterations,
            HashAlgorithmName.SHA256
        );

        var salt = algorithm.Salt;
        var hash = algorithm.GetBytes(HashSize);

        var hashBytes = new byte[salt.Length + hash.Length];
        Buffer.BlockCopy(salt, 0, hashBytes, 0, salt.Length);
        Buffer.BlockCopy(hash, 0, hashBytes, salt.Length, hash.Length);

        return Convert.ToBase64String(hashBytes);
    }

    public bool VerifyPassword(string password, string hash)
    {
        if (string.IsNullOrWhiteSpace(password))
            return false;

        if (string.IsNullOrWhiteSpace(hash))
            return false;

        var hashBytes = Convert.FromBase64String(hash);

        var salt = new byte[SaltSize];
        Buffer.BlockCopy(hashBytes, 0, salt, 0, SaltSize);

        using var algorithm = new Rfc2898DeriveBytes(
            password,
            salt,
            Iterations,
            HashAlgorithmName.SHA256
        );

        var computedHash = algorithm.GetBytes(HashSize);

        for (int i = 0; i < computedHash.Length; i++)
        {
            if (hashBytes[SaltSize + i] != computedHash[i])
                return false;
        }

        return true;
    }
}
