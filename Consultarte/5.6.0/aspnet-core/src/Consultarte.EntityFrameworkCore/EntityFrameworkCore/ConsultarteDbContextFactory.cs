using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Consultarte.Configuration;
using Consultarte.Web;

namespace Consultarte.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ConsultarteDbContextFactory : IDesignTimeDbContextFactory<ConsultarteDbContext>
    {
        public ConsultarteDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ConsultarteDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ConsultarteDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ConsultarteConsts.ConnectionStringName));

            return new ConsultarteDbContext(builder.Options);
        }
    }
}
