using System;


namespace HandMadeShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private HandMadeShopDbContext dbContext;

        public HandMadeShopDbContext Init()
        {
            return dbContext ?? (dbContext = new HandMadeShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}