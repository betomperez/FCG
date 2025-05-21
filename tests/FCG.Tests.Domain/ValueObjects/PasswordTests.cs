using FCG.Tests.Domain.Mocks;
using FCG.Domain.ValueObjects;

namespace FCG.Tests.Domain.ValueObjects;

public class PasswordTests
{
    private readonly MockPasswordHasher _hasher = new();

    [Fact]
    public void Create_ValidPassword_CreatesPassword()
    {
        // Arrange & Act
        var password = Password.Create("Senha@123", _hasher);

        // Assert
        Assert.NotNull(password);
        Assert.StartsWith("MOCKHASHED_", password.Hash);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("Short")]
    [InlineData("N0especial")]
    [InlineData("NoNumber$")]
    [InlineData("12345678")]
    public void Create_InvalidPassword_ThrowsException(string invalidPassword)
    {
        // Arrange & Act, Assert
        Assert.Throws<ArgumentException>(() => Password.Create(invalidPassword, _hasher));
    }

    [Fact]
    public void Verify_CorrectPassword_ReturnsTrue() 
    { 
        // Arrange
        var password = Password.Create("Senha@123", _hasher);

        // Act
        var result = password.Verify("Senha@123", _hasher);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Verify_IncorrectPassword_ReturnsFalse()
    {
        // Arrange
        var password = Password.Create("Senha@123", _hasher);

        // Act
        var result = password.Verify("Pa$$word1", _hasher);

        // Assert
        Assert.False(result);
    }
}
