using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using PaulExpress.Api.Authentication.Authorization;
using PaulExpress.Domain.Config;

namespace PaulExpress.Api.Authentication
{
    public static class ServiceCollectionExtensions
    {
        public static void SetupAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            AppSettings settings = configuration.GetSection("AppSettings").Get<AppSettings>();

            var key = Encoding.ASCII.GetBytes(settings.JWTSecret);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                };

            });

            services.AddScoped<JWTUserService>();
            services.AddSingleton<IAuthorizationPolicyProvider, UserActionPolicyProvider>();
            services.AddSingleton<IAuthorizationHandler, UserActionAuthorizationHandler>();
        }
    }
}