using System.Security.Claims;

namespace CertificationManager.Shared.Extensions
{
    public static class ClaimsExtension
    {
        public static string GetUserId(this ClaimsPrincipal User)
        {
            return User.FindFirst(ClaimTypes.Upn)?.Value ??
               User.FindFirst(ClaimTypes.Name)?.Value;
        }

        public static string GetUserName(this ClaimsPrincipal User)
        {
            return User.FindFirst(ClaimTypes.GivenName)?.Value + " " + User.FindFirst(ClaimTypes.Surname)?.Value;
        }

    }
}
