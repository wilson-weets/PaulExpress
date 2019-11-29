using AutoMapper;
using NsiTools.EfUtils.Core;
using PaulExpress.Abstractions.Repositories;
using PaulExpress.Abstractions.Services;
using PaulExpress.Domain.Dtos.Simple;
using PaulExpress.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaulExpress.BusinessLogic.Services
{
    class ShopService: SearchRepositoryBase, IShopService
    {
        private readonly IMapper _mapper;
        private readonly IShopRepository _shopRepository;
        public ShopService(IMapper mapper, IShopRepository shopRepository)
        {
            _mapper = mapper;
            _shopRepository = shopRepository;
        }
        public ShopDto GetShop(int shopId)
        {
            Shop dbo = _shopRepository.GetById(shopId);
            return _mapper.Map<ShopDto>(dbo);
        }
    }
}
