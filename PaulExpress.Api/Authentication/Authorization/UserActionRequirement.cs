using Microsoft.AspNetCore.Authorization;
using PaulExpress.Domain.Enums;

namespace PaulExpress.Api.Authentication.Authorization
{
    public class UserActionRequirement : IAuthorizationRequirement
    {
        public EActions[] Actions { get; private set; }

        public UserActionRequirement(params EActions[] actions)
        {
            Actions = actions;
        }
    }
}