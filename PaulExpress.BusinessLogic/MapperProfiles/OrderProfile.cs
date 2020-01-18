using AutoMapper;
using PaulExpress.Domain.Dtos.Details;
using PaulExpress.Domain.Dtos.Simple;
using PaulExpress.Domain.Entities;

namespace PaulExpress.BusinessLogic.MapperProfiles
{
    public class OrderProfile: Profile
    {
        public OrderProfile()
        {
            #region Order

            CreateMap<Order, OrderDto>();
            CreateMap<Order, OrderGridDto>()
                .ForMember(dto => dto.OrderStatusName, cfg => cfg.MapFrom(dbo => dbo.OrderStatus.Name));
            CreateMap<Order, OrderDetailDto>()
                .ForMember(dto => dto.OrderStatusCode, cfg => cfg.MapFrom(dbo => dbo.OrderStatus.Code));

            #endregion

            #region OrderLine

            CreateMap<OrderLine, OrderLineDto>();
            CreateMap<OrderLine, OrderLineGridDto>()
                .ForMember(dto => dto.OrderDate, cfg => cfg.MapFrom(dbo => dbo.Order.StartDate))
                //.ForMember(dto => dto.UserName, cfg => cfg.MapFrom(dbo => dbo.User.)) TODO
                //.ForMember(dto => dto.UserEmail, cfg => cfg.MapFrom(dbo => dbo.User.)) TODO
                .ForMember(dto => dto.PaymentMethodName, cfg => cfg.MapFrom(dbo => dbo.PaymentMethod.Name))
                .ForMember(dto => dto.SandwichName, cfg => cfg.MapFrom(dbo => dbo.Sandwich.Name))
                .ForMember(dto => dto.SauceName, cfg => cfg.MapFrom(dbo => dbo.Sauce.Name));

            #endregion

            #region OrderLineSupplement

            CreateMap<OrderLineSupplement, OrderLineSupplementDto>();

            #endregion

            #region PaymentMethod

            CreateMap<PaymentMethod, PaymentMethodDto>();

            #endregion

            #region OrderStatus

            CreateMap<OrderStatus, OrderStatusDto>();

            #endregion
        }
    }
}