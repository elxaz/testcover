using Microsoft.EntityFrameworkCore;

namespace Flax.Database
{
    public class DatabaseContext : DbContext
    {
        private readonly string connectionString;

        public DatabaseContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseMySQL(connectionString);
    }
}