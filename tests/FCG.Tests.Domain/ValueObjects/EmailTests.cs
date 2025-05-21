using FCG.Domain.ValueObjects;

namespace FCG.Domain.Tests.ValueObjects;

public class EmailTests
{
    [Theory]
    [InlineData("aluno@fiap.com.br")]
    [InlineData("professor@pm3.com.br")]
    [InlineData("user@alura.com.br")]
    public void Constructor_ValidAddress_CreatesEmail(string validAddress)
    {
        // Arrange & Act
        Email email = new Email(validAddress);

        // Assert
        Assert.NotNull(email);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("aluno@google.com.br")]
    public void Constructor_InvalidAdress_ThrowsArgumentException(string invalidEmail)
    {
        // Arrange, Act &Assert
        Assert.Throws<ArgumentException>(() => new Email(invalidEmail));
    }

    [Fact]
    public void ToString_ValidEmail_ReturnsEmailAddress()
    {
        // Arrange & Act
        Email email = new Email("aluno@fiap.com.br");

        // Assert
        Assert.Equal("aluno@fiap.com.br", email.ToString());
    }
}
