using CQRS_Wrokshop.Domain.Entities;
using CQRS_Wrokshop.Domain.Respositories;
using CQRS_Wrokshop.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_Wrokshop.Infrastructure.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private readonly CQRSWorkShopDbContext _context;
        public OrderRepository(CQRSWorkShopDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
