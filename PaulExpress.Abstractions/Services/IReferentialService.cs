using PaulExpress.Abstractions.Repositories;
using PaulExpress.Domain.Dtos.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaulExpress.Abstractions.Services
{
    public interface IReferentialService
    {
        List<ReferentialItemDto> GetSauces(int shopId);
        List<ReferentialItemDto> GetSupplements(int shopId);
    }
}
