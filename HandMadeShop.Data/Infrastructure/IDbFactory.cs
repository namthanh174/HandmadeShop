using System;

namespace HandMadeShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        HandMadeShopDbContext Init();
    }
}