using FCG.Domain.Enums;
using FCG.Domain.Interfaces;
using FCG.Domain.ValueObjects;

namespace FCG.Domain.Entities;

public class User
{
    public Guid Id { get; init; }
    public string Name { get; private set; }
    public Email Email { get; private set; }
    public Password Password { get; private set; }
    public  UserRole Role { get; private set; }
    public User(string name, Email email, Password password, UserRole role = UserRole.User)
    {
        ValidateName(name);
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        Password = password;
        Role = role;
    }

    private User()
    {
        Name = null!;
        Email = null!;
        Password = null!;
    }

    private static void ValidateName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Nome não pode ser nulo ou vazio.", nameof(name));
    }

    public void ChangeName(string name)
    {
        ValidateName(name);
        Name = name;
    }

    public void ChangeEmail(string email) => Email = new Email(email);

    public void ChangePassword(string plainTextPassword, IPasswordHasher hasher) => Password = Password.Create(plainTextPassword, hasher);

    public void ChangeRole(UserRole role) => Role = role;

    public bool IsPasswordValid(string plainTextPassword, IPasswordHasher hasher) => Password.Verify(plainTextPassword, hasher);
}
