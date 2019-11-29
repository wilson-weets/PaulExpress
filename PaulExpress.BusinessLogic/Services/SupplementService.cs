using AutoMapper;
using PaulExpress.Abstractions.Repositories;
using PaulExpress.Domain.Dtos.Simple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PaulExpress.BusinessLogic.Services
{
    public class SupplementService
    {
        private readonly ISupplementRepository _supplementRepository;
        private readonly IMapper _mapper;

        public SupplementService(ISupplementRepository supplementRepository, IMapper mapper)
        {
            _supplementRepository = supplementRepository;
            _mapper = mapper;
        }

        public List<SupplementDto> GetSupplementByShopId(int shopId)
        {
            //return _supplementRepository.Query.Where(s => s.shopId).toList();
            return null;
        }
    }
}
