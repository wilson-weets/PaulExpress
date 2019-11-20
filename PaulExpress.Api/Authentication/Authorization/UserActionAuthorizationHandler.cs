using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace PaulExpress.Api.Authentication.Authorization
{
    internal class UserActionAuthorizationHandler : AuthorizationHandler<UserActionRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, UserActionRequirement requirement)
        {
            if (context.User.HasAnyAction(requirement.Actions))
            {
                context.Succeed(requirement);
            }
            else
            {
                context.Fail();
            }
            return Task.CompletedTask;
        }
    }
}