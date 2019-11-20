using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using PaulExpress.Domain.Config;
using PaulExpress.Domain.Dtos.Internal;
using PaulExpress.Domain.Enums;

namespace PaulExpress.Api.Authentication
{
    public class JWTUserService
    {
        public const string ClaimUniqueJwtGuid = "JwtGuid";
        public const string ClaimAction = "Action";
        public const string ClaimUserId = "UserId";

        private readonly AppSettings _appSettings;

        public JWTUserService(IOptions<AppSettings> appSettingsOptions)
        {
            this._appSettings = appSettingsOptions.Value;
        }

        public UserDto Authenticate(AuthenticateDto auth)
        {
            // TODO : Call user service with auth information to get the user 
            // _userService.Getuser(auth)...

            // Get from db
            UserDto user = new UserDto();
            user.FirstName = "Test First Name";
            user.LastName = "Test Last Name";
            user.UserName = auth.UserName;
            user.Email = "test@test.com";

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.JWTSecret);

            var actionListClaims = new List<Claim>();

            var userActionsCodes = new[] { EActions.ViewHome.ToString() }; // GET CURRENT USER ACTION CODES FROM DATABASe
            var userRole = "RegularUser"; // Get user role from database
            var userId = 1; // Get user id from database (If needed...)

            actionListClaims.AddRange(userActionsCodes.Select(code => new Claim(ClaimAction, code)).ToList());

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