using System.Collections.Generic;
using PaulExpress.Domain.Dtos.Internal;
using PaulExpress.Domain.Dtos.Simple;

namespace PaulExpress.Abstractions.Services
{
    public interface IUserService
    {
        UserDto GetUser(AuthenticateDto auth);
        List<string> GetActionCodes(int userId);
        string GetMainRole(int userId);
    }
}