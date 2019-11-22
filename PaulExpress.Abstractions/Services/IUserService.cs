using PaulExpress.Domain.Dtos.Internal;
using PaulExpress.Domain.Dtos.Simple;

namespace PaulExpress.Abstractions.Services
{
    public interface IUserService
    {
        UserDto Authenticate(AuthenticateDto auth);
    }
}