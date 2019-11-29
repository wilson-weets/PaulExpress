using AutoMapper;
using AutoMapper.QueryableExtensions;
using PaulExpress.Abstractions.Repositories;
using PaulExpress.Abstractions.Services;
using PaulExpress.Domain.Dtos.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PaulExpress.BusinessLogic.Services
{
    public class ReferencialService : IReferentialService
    {
        private readonly ISupplementRepository _supplementRepository;
        private readonly ISauceRepository _sauceRepository;
        private readonly IMapper _mapper;

        public ReferencialService(ISupplementRepository supplementRepository, ISauceRepository sauceRepository, IMapper mapper)
        {
            _supplementRepository = supplementRepository;
            _mapper = mapper;
            _sauceRepository = sauceRepository;
        }

        public List<ReferentialItemDto> GetSauces(int shopId)
        {
            return _sauceRepository.Query.Where(s => s.ShopId == shopId).ProjectTo<ReferentialItemDto>(_mapper.ConfigurationProvider).ToList();
        }

        public List<ReferentialItemDto> GetSupplements(int shopId)
        {
            return _supplementRepository.Query.Where(s => s.ShopId == shopId).ProjectTo<ReferentialItemDto>(_mapper.ConfigurationProvider).ToList();
        }
    }
}
