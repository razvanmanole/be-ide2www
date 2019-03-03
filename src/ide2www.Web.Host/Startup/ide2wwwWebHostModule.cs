using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ide2www.Configuration;

namespace ide2www.Web.Host.Startup
{
    [DependsOn(
       typeof(ide2wwwWebCoreModule))]
    public class ide2wwwWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ide2wwwWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ide2wwwWebHostModule).GetAssembly());
        }
    }
}
