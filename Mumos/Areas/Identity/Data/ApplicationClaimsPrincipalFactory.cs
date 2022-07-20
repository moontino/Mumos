using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Mumos.Models;
using System.Security.Claims;
using System.Threading.Tasks;


namespace Mumos.Areas.Identity.Data
{
    public class ApplicationClaimsPrincipalFactory : UserClaimsPrincipalFactory<ApplicationUser,IdentityRole>
    {
        public ApplicationClaimsPrincipalFactory(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IOptions<IdentityOptions> optionsAccessor) 
            : base(userManager,roleManager, optionsAccessor)
        {
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(ApplicationUser user)
        {
            var identity = await base.GenerateClaimsAsync(user);

            identity.AddClaim(new Claim("UserName", user.UserName));

            return identity;
        }
    }
}
