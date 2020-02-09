using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using PaulExpress.Abstractions.Services;
using PaulExpress.Domain.Config;
using PaulExpress.Domain.Dtos.Internal;
using PaulExpress.Domain.Dtos.Simple;
using PaulExpress.Domain.Enums;

namespace PaulExpress.Api.Authentication
{
    public class JWTUserService
    {
        public const string ClaimUniqueJwtGuid = "JwtGuid";
        public const string ClaimAction = "Action";
        public const string ClaimUserId = "UserId";

        private readonly AppSettings _appSettings;
        private readonly IUserService _userService;

        public JWTUserService(IOptions<AppSettings> appSettingsOptions, IUserService userService)
        {
            _userService = userService;
            this._appSettings = appSettingsOptions.Value;
        }

        public UserDto Authenticate(AuthenticateDto auth)
        {
            // Get from db
            UserDto user = _userService.GetUser(auth);

            if (user == null)
            {
                return null;
            }

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.JWTSecret);

            var actionListClaims = new List<Claim>();

            var userActionsCodes = _userService.GetActionCodes(user.UserId); // GET CURRENT USER ACTION CODES FROM DATABASe
            var userRole = _userService.GetMainRole(user.UserId); // Get user role from database
            if (userRole == null)
            {
                return null;
            }
            var userId = user.UserId; // Get user id from database (If needed...)

            actionListClaims.AddRange(userActionsCodes.Select(code => new Claim(ClaimAction, code)).ToList());

            actionListClaims.Add(new Claim(ClaimTypes.Name, user.Trigram));
            actionListClaims.Add(new Claim(ClaimTypes.Role, userRole));
            actionListClaims.Add(new Claim(ClaimUserId, userId.ToString()));
            actionListClaims.Add(new Claim(ClaimUniqueJwtGuid, Guid.NewGuid().ToString()));
            actionListClaims.Add(new Claim(ClaimTypes.Email, user.Email));

            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(actionListClaims),
                Expires = DateTime.Now.AddDays(7),  // Validity of jwt defined here
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);

            user.Token = tokenHandler.WriteToken(token);
            return user;
        }
    }
}