using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Consultarte.Configuration;

namespace Consultarte.Web.Host.Startup
{
    [DependsOn(
       typeof(ConsultarteWebCoreModule))]
    public class ConsultarteWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ConsultarteWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ConsultarteWebHostModule).GetAssembly());
        }
    }
}
