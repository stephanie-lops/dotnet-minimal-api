using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace MinimalApi.Infraestrutura.Db
{
    public class DbContextoFactory : IDesignTimeDbContextFactory<DbContexto>
    {
        public DbContexto CreateDbContext(string[] args)
        {
            // Carrega o appsettings.json manualmente para o design-time
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<DbContexto>();
            var connectionString = configuration.GetConnectionString("mysql");

            optionsBuilder.UseMySql(
                connectionString,
                ServerVersion.AutoDetect(connectionString)
            );

            return new DbContexto(configuration);
        }
    }
}
