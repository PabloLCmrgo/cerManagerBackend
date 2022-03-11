namespace CertificationManager.Shared.Settings
{
    public class AuthenticationSettings
    {
        public string Instance { get; set; }
        public string TenantId { get; set; }
        public string Audience { get; set; }

        public string Authority => $"{Instance}{TenantId}";

        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string UrlToken { get; set; }
    }
}
