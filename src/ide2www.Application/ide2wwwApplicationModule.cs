using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ide2www.Authorization;

namespace ide2www
{
    [DependsOn(
        typeof(ide2wwwCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ide2wwwApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ide2wwwAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ide2wwwApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
