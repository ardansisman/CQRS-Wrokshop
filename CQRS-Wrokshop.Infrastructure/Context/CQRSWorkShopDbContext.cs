using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_Wrokshop.Infrastructure.Context
{
    public class CQRSWorkShopDbContext:DbContext
    {
        public CQRSWorkShopDbContext(DbContextOptions<CQRSWorkShopDbContext> options): base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies(false);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.HasDefaultSchema("public");
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CQRSWorkShopDbContext).Assembly);
        }
    }
}
