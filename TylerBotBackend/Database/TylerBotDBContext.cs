using Microsoft.EntityFrameworkCore;

namespace TylerBotBackend.Database
{
    public class TylerBotDBContext : DbContext
    {
        public TylerBotDBContext(DbContextOptions<TylerBotDBContext> contextOptions) : base(contextOptions)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("AppDb");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
