﻿using HandMadeShop.Data.Infrastructure;
using HandMadeShop.Model.Models;

namespace HandMadeShop.Data.Repositories
{
    public interface IPostRepository
    {
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}