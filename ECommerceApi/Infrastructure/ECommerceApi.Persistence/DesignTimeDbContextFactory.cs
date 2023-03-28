using ECommerceApi.Persistence.Context;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ECommerceApiDbContext>
    {
        public ECommerceApiDbContext CreateDbContext(string[] args)
        {

            DbContextOptionsBuilder<ECommerceApiDbContext> dbContextOptionsBuilder = new DbContextOptionsBuilder<ECommerceApiDbContext>();
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
            return new ECommerceApiDbContext(dbContextOptionsBuilder.Options);
        }
    }
}
