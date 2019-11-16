using System.Linq;
using System.Security.Claims;
using PaulExpress.Domain.Enums;

namespace PaulExpress.Api.Authentication
{
    public static class ClaimsPrincipalExtensions
    {
        public static bool HasAnyAction(this ClaimsPrincipal user, params EActions[] actions)
        {
            var allUserActions = user.FindAll(JWTUserService.ClaimAction).Select(c => c.Value);
            var currentActions = actions.Select(d => d.ToString());
            return allUserActions.Intersect(currentActions).Any();
        }
    }
}