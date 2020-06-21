using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Consultarte.Authorization;

namespace Consultarte
{
    [DependsOn(
        typeof(ConsultarteCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ConsultarteApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ConsultarteAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ConsultarteApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
