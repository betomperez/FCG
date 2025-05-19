//using FCG.Domain.Entities;

namespace FCG.Tests.Domain.Entities;

public class UserTests
{
    [Fact]
    public void Constructor_ValidName_CreatesUser()
    {
        // Arrange & act
        // User user = new User("Maria Silva", "rm000000@fiap.com.br", "Senha@123");

        // Assert
        Assert.Fail("Test not implemented");
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    public void Constructor_InvalidName_ThrowsException(string invalidName)
    {
        // Arrange, Act & Assert
        //Assert.Throws<ArgumentException>(() => new User(invalidName, "rm000000@fiap.com.br", "Senha@123"));

        Assert.Fail("Test not implemented");
    }

    [Fact]
    public void Constructor_UserRoleIsUser_ReturnsTrue()
    {
        // Arrange, Act
        //User user = new User("Maria Silva", "rm000000@fiap.com.br", "Senha@123");

        // Assert
        //Assert.True(user.Role == UserRole.User);
        Assert.Fail("Test not implemented");
    }

    [Fact]
    public void ChangeRole_UserRoleChanged_RoleChanged()
    {
        // Arrange
        //User user = new User("Maria Silva", "rm000000@fiap.com.br", "Senha@123");
        //User admin = new User("José Santos" "professor@alura.com.br, "Pa$$w0rd", UserRole.Admin);

        // Act
        //user.ChangeRole(UserRole.Admin);
        //admin.ChangeRole(UserRole.User);

        // Assert
        //Assert.Equal(user.Role, UserRole.Admin);
        //Assert.Equal(admin.Role, UserRole.User);
        Assert.Fail("Test not implemented");
    }

    [Fact]
    public void ChageName_ModifyName_NameModified()
    {
        // Arrange
        //User user = new User("Maria Siuva", "rm000000@fiap.com.br", "Senha@123");

        // Act
        //user.ChangeName("Maria Silva");

        // Assert
        //Assert.Equal("Maria Silva", user.Name);
        Assert.Fail("Test not implemented");
    }

    [Fact]
    public void ChangePassword_ModifyPassword_PasswordlModified()
    {
        // Arrange
        //User user = new User("Maria Silva", "rm000000@fiap.com.br", "Senha@123");

        // Act
        //user.ChangePassword("Senha@123", "Pa$$w0rd");

        // Assert
        //Assert.True(user.VerifyPassword("Pa$$w0rd"));
        Assert.Fail("Test not implemented");
    }

    [Fact]
    public void ChangeEmail_ModifyEMail_EmailModified()
    {
        // Arrange
        //User user = new User("Maria Silva", "rm000000@fiap.com.br", "Senha@123");

        // Act
        //user.ChangeEmail("professor@alura");

        // Assert
        //Assert.Equal("professor@alura", user.Email);
        Assert.Fail("Test not implemented");

    }
}
