using PaulExpress.Domain.Dtos.Internal;

namespace PaulExpress.Abstractions.Services
{
    public interface IUserService
    {
        UserDto Authenticate(AuthenticateDto auth);
    }
}