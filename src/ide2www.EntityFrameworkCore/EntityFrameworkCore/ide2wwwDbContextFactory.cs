using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ide2www.Configuration;
using ide2www.Web;

namespace ide2www.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ide2wwwDbContextFactory : IDesignTimeDbContextFactory<ide2wwwDbContext>
    {
        public ide2wwwDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ide2wwwDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ide2wwwDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ide2wwwConsts.ConnectionStringName));

            return new ide2wwwDbContext(builder.Options);
        }
    }
}
