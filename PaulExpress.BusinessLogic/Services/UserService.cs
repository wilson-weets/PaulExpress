using PaulExpress.Abstractions.Services;
using PaulExpress.Domain.Dtos.Internal;
using PaulExpress.Domain.Dtos.Simple;

namespace PaulExpress.BusinessLogic.Services
{
    public class UserService: IUserService
    {
        public UserDto Authenticate(AuthenticateDto auth)
        {
            // Call Real Database service to perform auth
            throw new System.NotImplementedException();
        }
    }
}