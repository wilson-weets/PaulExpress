﻿using PaulExpress.Domain.Dtos.Simple;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaulExpress.Abstractions.Services
{
    public interface IShopService
    {
        ShopDto GetShop(int ShopId);
    }
}
