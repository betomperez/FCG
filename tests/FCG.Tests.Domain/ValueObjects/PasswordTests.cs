namespace FCG.Tests.Domain.ValueObjects
{
    public class PasswordTests
    {
        [Fact]
        public void Constructor_ValidPassword_CreatesPassword()
        {
            // Arrange & Act
            // Password password = new Password("Senha@123");

            // Assert
            // Assert.NotNull(password);
            Assert.Fail("To be implemented");
        }

        [Theory]
        [InlineData(null)]
        [InlineData("S1@")]
        [InlineData("Password1")]
        [InlineData("Pa$$word")]
        [InlineData("12345678")]
        public void Constructor_InvalidPassword_ThrowsException(string invalidPassword)
        {
            // Arrange & Act
            // Password password = new Password(invalidPassword);

            // Assert
            Assert.Fail("To be implemented");
        }
    }
}
