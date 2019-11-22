using AutoMapper;
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

            #endregion

            #region OrderLine

            CreateMap<OrderLine, OrderLineDto>();

            #endregion

            #region OrderLineSupplement

            CreateMap<OrderLineSupplement, OrderLineSupplementDto>();

            #endregion

            #region PaymentMethod

            CreateMap<PaymentMethod, PaymentMethodDto>();

            #endregion
        }
    }
}