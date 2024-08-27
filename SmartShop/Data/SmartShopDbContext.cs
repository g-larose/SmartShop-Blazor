using Microsoft.EntityFrameworkCore;

namespace SmartShop.Data
{
    public class SmartShopDbContext : DbContext
    {
        public SmartShopDbContext(DbContextOptions options) : base(options) { }
       
    }
}
