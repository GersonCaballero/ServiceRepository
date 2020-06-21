using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Consultarte.EntityFrameworkCore;
using Consultarte.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Consultarte.Web.Tests
{
    [DependsOn(
        typeof(ConsultarteWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ConsultarteWebTestModule : AbpModule
    {
        public ConsultarteWebTestModule(ConsultarteEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ConsultarteWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ConsultarteWebMvcModule).Assembly);
        }
    }
}