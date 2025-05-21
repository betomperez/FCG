using FCG.Domain.Entities;
using FCG.Domain.Enums;
using FCG.Domain.ValueObjects;
using FCG.Tests.Domain.Mocks;

namespace FCG.Tests.Domain.Entities;

public class UserTests
{
    private readonly MockPasswordHasher _hasher = new();

    [Fact]
    public void Constructor_ValidName_CreatesUser()
    {
        // Arrange & act
        var password = Password.Create("Senha@123", _hasher);
        var email = new Email("rm000000@fiap.com.br");
        var user = new User("Maria Silva", email, password);

        // Assert
        Assert.NotNull(user);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    public void Constructor_InvalidName_ThrowsException(string invalidName)
    {
        // Arrange, Act & Assert
        var password = Password.Create("Senha@123", _hasher);
        var email = new Email("rm000000@fiap.com.br");
        Assert.Throws<ArgumentException>(() => new User(invalidName, email, password));
    }

    [Fact]
    public void Constructor_UserRoleIsUser_ReturnsTrue()
    {
        // Arrange, Act
        var password = Password.Create("Senha@123", _hasher);
        var email = new Email("rm000000@fiap.com.br");
        var user = new User("Maria Silva", email, password);

        // Assert
        Assert.True(user.Role == UserRole.User);
    }

    [Fact]
    public void ChangeRole_UserRoleChanged_RoleChanged()
    {
        // Arrange
        var password = Password.Create("Senha@123", _hasher);
        var email = new Email("rm000000@fiap.com.br");
        var otherEmail = new Email ("professor@alura.com.br");
        var user = new User("Maria Silva", email, password);
        var admin = new User("José Santos", otherEmail, password, UserRole.Admin);

        // Act
        user.ChangeRole(UserRole.Admin);
        admin.ChangeRole(UserRole.User);

        // Assert
        Assert.Equal(UserRole.Admin, user.Role);
        Assert.Equal(UserRole.User, admin.Role);
    }

    [Fact]
    public void ChageName_ModifyName_NameModified()
    {
        // Arrange
        var password = Password.Create("Senha@123", _hasher);
        var email = new Email("rm000000@fiap.com.br");
        var user = new User("Maria Siuva", email, password);

        // Act
        user.ChangeName("Maria Silva");

        // Assert
        Assert.Equal("Maria Silva", user.Name);
    }

    [Fact]
    public void ChangePassword_ModifyPassword_PasswordlModified()
    {
        // Arrange
        var password = Password.Create("Senha@123", _hasher);
        var email = new Email("rm000000@fiap.com.br");
        var newPassword = "Pa$$w0rd";
        var user = new User("Maria Silva", email, password);

        // Act
        user.ChangePassword(newPassword, _hasher);

        // Assert
        Assert.True(user.IsPasswordValid("Pa$$w0rd", _hasher));
    }

    [Fact]
    public void ChangeEmail_ModifyEMail_EmailModified()
    {
        // Arrange
        var password = Password.Create("Senha@123", _hasher);
        var email = new Email("rm000000@fiap.com.br");
        var user = new User("Maria Silva", email, password);

        // Act
        user.ChangeEmail("professor@alura.com.br");

        // Assert
        Assert.Equal("professor@alura.com.br", user.Email.Address);
        

    }
}
