using System.Text.RegularExpressions;
using FCG.Domain.Interfaces;

namespace FCG.Domain.ValueObjects;

public class Password
{
    public string Hash { get; }

    private Password() { Hash = null!; } // For EF Core
    private Password(string hash) => Hash = hash;

    public static Password Create(string plainText, IPasswordHasher hasher)
    {
        ValidatePassword(plainText);
        return new Password(hasher.Hash(plainText));
    }

    public static Password FromHash(string hash) => new Password(hash);

    public bool Verify(string plainText, IPasswordHasher hasher) => hasher.Verify(plainText, Hash);

    private static void ValidatePassword(string plainText)
    {
        if (string.IsNullOrEmpty(plainText) || plainText.Length < 8 ) 
            throw new ArgumentException("Senha deve ter no mínimo 8 caracteres.", nameof(plainText));
        
        if (!Regex.IsMatch(plainText, "[A-Z]"))
            throw new ArgumentException("Senha deve conter pelo menos 1 letra maiúscula.", nameof(plainText));

        
        if (!Regex.IsMatch(plainText, "[a-z]"))
            throw new ArgumentException("Senha deve conter pelo menos 1 letra minúscula.", nameof(plainText));

        
        if (!Regex.IsMatch(plainText, "[0-9]"))
            throw new ArgumentException("Senha deve conter pelo menos 1 número.", nameof(plainText));

        
        if (!Regex.IsMatch(plainText, "[^a-zA-Z0-9]"))
            throw new ArgumentException("Senha deve conter pelo menos 1 caractere especial.", nameof(plainText));
    }
}
