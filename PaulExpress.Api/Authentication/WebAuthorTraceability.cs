using System;
using Microsoft.AspNetCore.Http;
using NsiTools.EfUtils.Core.Interfaces;

namespace PaulExpress.Api.Authentication
{
    public class WebAuthorTraceability : IAuthorTraceability
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public WebAuthorTraceability(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public override object GetTraceabilityFieldData()
        {
            return GetUserId();
        }

        /// <summary>
        /// Get User name from request 
        /// </summary>
        /// <returns>Username</returns>
        public override string GetUserName()
        {
            var login = _contextAccessor.HttpContext?.User
                            ?.Identity.Name ?? "NOT_DEFINED";
            return login;
        }


        public override int? GetUserId()
        {
            var userId = _contextAccessor.HttpContext?.User?.FindFirst(JWTUserService.ClaimUserId)?.Value;
            if (userId == null) return 2;
            return Convert.ToInt32(userId);
        }
    }
}