using AutoMapper;
using PaulExpress.Domain.Dtos.Details;
using PaulExpress.Domain.Dtos.Internal;
using PaulExpress.Domain.Dtos.Simple;
using PaulExpress.Domain.Entities;

namespace PaulExpress.BusinessLogic.MapperProfiles
{
    public class SandwichProfile: Profile
    {
        public SandwichProfile()
        {
            #region Sandwich

            CreateMap<Sandwich, SandwichDto>();

            #endregion

            #region Sauce

            CreateMap<Sauce, SauceDto>();

            #endregion

            #region Supplement

            CreateMap<Supplement, SupplementDto>();

            #endregion

            #region Shop

            CreateMap<Shop, ShopDto>();

            #endregion

            #region Referentials

            CreateMap<Sauce, ReferentialItemDto>()
                .ForMember(s => s.IdValue, cfg => cfg.MapFrom(dbo => dbo.SauceId))
                .ForMember(s => s.DisplayValue, cfg => cfg.MapFrom(dbo => dbo.Name))
                .ForMember(s => s.KeyValue, cfg => cfg.MapFrom(dbo => dbo.SauceId))
                ;

            CreateMap<Supplement, ReferentialItemDto>()
                .ForMember(s => s.IdValue, cfg => cfg.MapFrom(dbo => dbo.SupplementId))
                .ForMember(s => s.DisplayValue, cfg => cfg.MapFrom(dbo => dbo.Name))
                .ForMember(s => s.KeyValue, cfg => cfg.MapFrom(dbo => dbo.SupplementId))
                ;

            #endregion

            #region
            CreateMap<SandwichDto, SandwichDetailsDto>().ReverseMap();
            #endregion

        }
    }
}