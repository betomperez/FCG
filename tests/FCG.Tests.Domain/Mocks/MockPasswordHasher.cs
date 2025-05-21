using FCG.Domain.Interfaces;

namespace FCG.Tests.Domain.Mocks;

public class MockPasswordHasher : IPasswordHasher
{
    public string Hash(string plainTextPassword) => $"MOCKHASHED_{plainTextPassword}";

    public bool Verify(string plainTextPassword, string hash) => hash == $"MOCKHASHED_{plainTextPassword}" ;
}
