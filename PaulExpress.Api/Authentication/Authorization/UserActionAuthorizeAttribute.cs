using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using PaulExpress.Domain.Enums;

namespace PaulExpress.Api.Authentication.Authorization
{
    internal class UserActionAuthorizeAttribute : AuthorizeAttribute
    {
        public const string POLICY_PREFIX = "UserActions__";

        public UserActionAuthorizeAttribute(params EActions[] actions)
        {
            Actions = actions;
        }

        public EActions[] Actions
        {
            get => ExtractActionsFromstring(Policy);
            set => Policy = $"{POLICY_PREFIX}{string.Join(",", value)}";
        }

        internal static EActions[] ExtractActionsFromstring(string policy)
        {
            var actionList = policy.Substring(POLICY_PREFIX.Length);
            return actionList.Split(",").Select(Enum.Parse<EActions>).ToArray();
        }
    }
}