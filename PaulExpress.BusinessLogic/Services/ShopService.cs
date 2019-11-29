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
    class ShopService: SearchRepositoryBase, IShopService
    {
        private readonly IMapper _mapper;
        private readonly IShopRepository _shopRepository;
        private readonly ISupplementRepository _supplementRepository;
        private readonly ISandwichRepository _sandwichRepository;
        private readonly ISauceRepository _sauceRepository;
        public ShopService(IMapper mapper, IShopRepository shopRepository, ISupplementRepository supplementRepository, ISandwichRepository sandwichRepository, ISauceRepository sauceRepository)
        {
            _mapper = mapper;
            _shopRepository = shopRepository;
            _supplementRepository = supplementRepository;
            _sandwichRepository = sandwichRepository;
            _sauceRepository = sauceRepository;
        }
        public ShopDto GetShop(int shopId)
        {
            Shop dbo = _shopRepository.GetById(shopId);
            return _mapper.Map<ShopDto>(dbo);
        }

        public List<SauceDto> GetSaucesByShopId(int shopId)
        {
            return _sauceRepository.Query.Where(s => s.ShopId == shopId).ProjectTo<SauceDto>(_mapper.ConfigurationProvider).ToList();
        }

        public List<SupplementDto> GetSupplementsByShopId(int shopId)
        {
            return _supplementRepository.Query.Where(s => s.ShopId == shopId).ProjectTo<SupplementDto>(_mapper.ConfigurationProvider).ToList();
        }

        public List<SandwichDto> GetSandwichesFromShop(int shopId)
        {
            return _sandwichRepository.Query.Where(s => s.ShopId == shopId).ProjectTo<SandwichDto>(_mapper.ConfigurationProvider).ToList();
        }
    }
}
