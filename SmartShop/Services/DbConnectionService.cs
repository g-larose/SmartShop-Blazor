using SmartShop.Interfaces;
using SmartShop.Models;
using System.Text.Json;

namespace SmartShop.Services
{
    public class DbConnectionService : IDbConnectionService
    {
        public string GetConnectionString()
        {
            string file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "config.json");
            var json = JsonSerializer.Deserialize<ConfigJson>(file)!;
            var connStr = json.ConnectionString!;
            return connStr;
        }
    }
}
