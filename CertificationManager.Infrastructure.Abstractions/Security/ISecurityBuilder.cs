namespace CertificationManager.Infrastructure.Abstractions.Security
{
    public interface ISecurityBuilder
    {
        
        ISecurityBuilder WithEmail(string email);
        ISecurityBuilder Build();
        string Email();
    }
}
