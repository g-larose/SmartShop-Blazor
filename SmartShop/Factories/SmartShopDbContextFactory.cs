using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SmartShop.Data;
using SmartShop.Interfaces;
using SmartShop.Services;

namespace SmartShop.Factories
{
    public class SmartShopDbContextFactory : IDesignTimeDbContextFactory<SmartShopDbContext>
    {
        private readonly IDbConnectionService? conService = new DbConnectionService();
        public SmartShopDbContext CreateDbContext(string[]? args = null)
        {
            string conStr = conService.GetConnectionString();
            var options = new DbContextOptionsBuilder<SmartShopDbContext>();
            options.UseNpgsql(conStr);
            return new SmartShopDbContext(options.Options);
        }
    }
}
