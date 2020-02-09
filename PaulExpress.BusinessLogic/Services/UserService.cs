using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using PaulExpress.Abstractions;
using PaulExpress.Abstractions.Repositories;
using PaulExpress.Abstractions.Services;
using PaulExpress.Domain.Dtos.Internal;
using PaulExpress.Domain.Dtos.Simple;
using PaulExpress.Domain.Entities;

namespace PaulExpress.BusinessLogic.Services
{
    public class UserService: IUserService
    {
        private readonly IMapper _mapper;
        private readonly IPaulExpressUnitOfWork _uow;
        private readonly IUserRoleRepository _userRoleRepository;
        private readonly IActionRepository _actionRepository;
        private readonly IUserRepository _userRepository;

        public UserService(IMapper mapper, IPaulExpressUnitOfWork uow, IUserRoleRepository userRoleRepository, IActionRepository actionRepository, IUserRepository userRepository)
        {
            _mapper = mapper;
            _uow = uow;
            _userRoleRepository = userRoleRepository;
            _actionRepository = actionRepository;
            _userRepository = userRepository;
        }

        public UserDto GetUser(AuthenticateDto auth)
        {
            return _mapper.Map<UserDto>(_uow.GetRepository<User>().Query.SingleOrDefault(p => p.Trigram == auth.UserName));
        }

        public List<string> GetActionCodes(int userId)
        {
            List<int> roles = _userRoleRepository.Query.Where(ur => ur.UserId == userId).Select(ur => ur.RoleId).ToList();
            return _actionRepository.Query.Where(a =>
                a.ActionRoles.Any(ar =>
                    roles.Contains(ar.RoleId)
                )
            )
            .Select(a => a.Code)
            .ToList();
        }

        public string GetMainRole(int userId)
        {
            return _userRepository.GetById(userId).UserRoles.OrderBy(ur => ur.RoleId).FirstOrDefault()?.Role?.RoleName;
        }
    }
}