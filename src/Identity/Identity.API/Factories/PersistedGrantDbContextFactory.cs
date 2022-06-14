using System.Security.AccessControl;
using IdentityServer4.EntityFramework.DbContexts;
using IdentityServer4.EntityFramework.Options;
using Microsoft.EntityFrameworkCore;

namespace Identity.API.Factories
{
    public class PersistedGrantDbContextFactory
    {
        public PersistedGrantDbContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
               .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
               .AddJsonFile("appsettings.json")
               .AddEnvironmentVariables()
               //.AddUserSecrets(Assembly.GetAssembly(typeof(Startup)))
               .Build();

            var optionsBuilder = new DbContextOptionsBuilder<PersistedGrantDbContext>();
            var operationOptions = new OperationalStoreOptions();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"), 
            sqlServerOptionsAction: o => o.MigrationsAssembly(typeof(Program).Assembly.FullName));


            return new PersistedGrantDbContext(optionsBuilder.Options, operationOptions);
        }
    }
}