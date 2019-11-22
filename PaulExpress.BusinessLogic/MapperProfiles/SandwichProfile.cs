using AutoMapper;
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
        }
    }
}