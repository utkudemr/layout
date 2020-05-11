using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Core.Extensions
{
    public static class ClaimsPrincipalExtensions
    {
        public static List<string> Claims(this ClaimsPrincipal claimsPrincipal,string claimType)
        {
            var result = claimsPrincipal?.FindAll(claimType)?.Select(x => x.Value).ToList();
            return result;
        }

        public static List<string> ClaimRoles(this ClaimsPrincipal claimsPrincipal)
        {
            return claimsPrincipal?.Claims(ClaimTypes.Role);
        }

        public static string ClaimId(this ClaimsPrincipal claimsPrincipal)
        {
            return claimsPrincipal?.Claims(ClaimTypes.NameIdentifier).First();
        }
        public static string ClaimNameSurname(this ClaimsPrincipal claimsPrincipal)
        {
            return claimsPrincipal?.Claims(ClaimTypes.Name).First();
        }
        public static string ClaimImage(this ClaimsPrincipal claimsPrincipal)
        {
            return claimsPrincipal?.Claims(ClaimTypes.UserData).First();
        }
        public static string ClaimRoleId(this ClaimsPrincipal claimsPrincipal)
        {
            return claimsPrincipal?.Claims(ClaimTypes.WindowsUserClaim).First();
        }


        public static List<string> ClaimSubRoles(this ClaimsPrincipal claimsPrincipal)
        {
            
            var asdsad= claimsPrincipal?.Claims(ClaimTypes.Role);
            return claimsPrincipal?.Claims(ClaimTypes.Role);
        }
    }
}
