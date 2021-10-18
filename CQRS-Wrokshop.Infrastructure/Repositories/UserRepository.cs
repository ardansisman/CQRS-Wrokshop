using CQRS_Wrokshop.Domain.Entities;
using CQRS_Wrokshop.Domain.Respositories;
using CQRS_Wrokshop.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Wrokshop.Infrastructure.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly CQRSWorkShopDbContext _context;
        public UserRepository(CQRSWorkShopDbContext context) : base(context)
        {
            _context = context;
        }

        public override Task<User> GetByIdAsync(int id)
        {
            return _context.Set<User>().Include(x => x.Orders)
                                       .AsNoTracking()
                                       .FirstOrDefaultAsync(x => x.Id == id);
        }
        public override Task<User> FirstOrDefaultAsync(Expression<Func<User, bool>> predicate)
        {
            return _context.Set<User>().Include(x => x.Orders)
                                       .AsNoTracking()
                                       .FirstOrDefaultAsync(predicate);
        }

        //public void Delete(int id) // TO DO : 
        //{
        //    _context.Set<User>().Where(x => x.Id == id ).UpdateFromQuery.(x => new User() { IsActive = false});

        //}
    }
}
