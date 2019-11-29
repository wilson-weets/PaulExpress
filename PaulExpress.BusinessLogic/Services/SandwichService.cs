using AutoMapper;
using AutoMapper.QueryableExtensions;
using NsiTools.EfUtils.Core;
using PaulExpress.Abstractions.Repositories;
using PaulExpress.Abstractions.Services;
using PaulExpress.Domain.Dtos.Simple;
using PaulExpress.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PaulExpress.BusinessLogic.Services
{
    public class SandwichService : SearchRepositoryBase, ISandwichService
    {
        private readonly IMapper _mapper;
        private readonly ISandwichRepository _sandwichRepository;
        public SandwichService(IMapper mapper, ISandwichRepository shopRepository)
        {
            _mapper = mapper;
            _sandwichRepository = shopRepository;
        }

        public SandwichDto GetSandwich(int id)
        {
            Sandwich dbo = _sandwichRepository.GetById(id);
            return _mapper.Map<SandwichDto>(dbo);
        }

        public List<SandwichDto> GetSandwichesFromShop(int shopId)
        {
            return _sandwichRepository.Query.Where(s => s.ShopId == shopId).ProjectTo<SandwichDto>(_mapper.ConfigurationProvider).ToList();
        }
    }
}
