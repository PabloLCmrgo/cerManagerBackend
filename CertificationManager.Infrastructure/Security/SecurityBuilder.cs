using CertificationManager.Infrastructure.Abstractions.Security;

namespace CertificationManager.Infrastructure.Security
{
    public class SecurityBuilder : ISecurityBuilder
    {
        string UserEmail;
        
        
        public ISecurityBuilder WithEmail(string email)
        {
            this.UserEmail = email;
            return this;
        }

        public ISecurityBuilder Build()
        {
            return this;
        }
        public string Email()
        {
            return UserEmail;
        }

    }
}
