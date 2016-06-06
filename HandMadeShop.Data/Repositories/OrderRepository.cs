using HandMadeShop.Data.Infrastructure;
using HandMadeShop.Model.Models;

namespace HandMadeShop.Data.Repositories
{
    public interface IOrderRepository
    {
    }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}