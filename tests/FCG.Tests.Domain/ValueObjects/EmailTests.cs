namespace FCG.Tests.Domain.ValueObjects;

public class EmailTests
{
    [Fact]
    public void Constructor_ValidAddress_CreatesEmail()
    {
        // Arrange

        // Act

        // Assert
        Assert.Fail("This test has not been implemented yet.");
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("invalid-email")]
    public void Constructor_InvalidAdress_ThrowsArgumentException(string invalidEmail)
    {
        // Arrange
        // Act
        // Assert
        Assert.Fail("This test has not been implemented yet.");
    }

    [Fact]
    public void ToString_ValidEmail_ReturnsEmailAddress()
    {
        // Arrange
        // Act
        // Assert
        Assert.Fail("This test has not been implemented yet.");
    }
}
