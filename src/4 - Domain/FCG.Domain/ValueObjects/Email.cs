using System.Text.RegularExpressions;

namespace FCG.Domain.ValueObjects;

public record Email
{
    public string Address { get; }

    public Email(string address)
    {
        ValidateAddress(address);
        ValidateDomain(address);
        Address = address;
    }

    private Email() { Address = null!; } // For EF Core

    private void ValidateDomain(string address)
    {
        string pattern = @"@(fiap\.com\.br|pm3\.com\.br|alura\.com\.br)$";
        if (!Regex.IsMatch(address, pattern, RegexOptions.IgnoreCase))
            throw new ArgumentException("Invalid Domain", nameof(address));
    }

    private void ValidateAddress(string address)
    {
        if (string.IsNullOrWhiteSpace(address))
            throw new ArgumentException("Email address cannot be null or empty.", nameof(address));
    }

    public override string ToString() => this.Address;
}
