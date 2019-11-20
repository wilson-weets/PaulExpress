using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;

namespace PaulExpress.Api.Authentication.Authorization
{
    public class UserActionPolicyProvider : IAuthorizationPolicyProvider
    {
        public DefaultAuthorizationPolicyProvider FallbackPolicyProvider { get; }
        public UserActionPolicyProvider(IOptions<AuthorizationOptions> options)
        {
            FallbackPolicyProvider = new DefaultAuthorizationPolicyProvider(options);
        }

        public Task<AuthorizationPolicy> GetDefaultPolicyAsync() => FallbackPolicyProvider.GetDefaultPolicyAsync();

        public Task<AuthorizationPolicy> GetFallbackPolicyAsync() => FallbackPolicyProvider.GetFallbackPolicyAsync();

        public Task<AuthorizationPolicy> GetPolicyAsync(string policyName)
        {
            if (policyName.StartsWith(UserActionAuthorizeAttribute.POLICY_PREFIX, StringComparison.OrdinalIgnoreCase))
            {
                var actions = UserActionAuthorizeAttribute.ExtractActionsFromstring(policyName);
                AuthorizationPolicyBuilder policy = new AuthorizationPolicyBuilder();
                policy.AddRequirements(new UserActionRequirement(actions));
                return Task.FromResult(policy.Build());
            }

            // If the policy name doesn't match the format expected by this policy provider,
            // try the fallback provider. If no fallback provider is used, this would return 
            // Task.FromResult<AuthorizationPolicy>(null) instead.
            return FallbackPolicyProvider.GetPolicyAsync(policyName);
        }  
    }
}