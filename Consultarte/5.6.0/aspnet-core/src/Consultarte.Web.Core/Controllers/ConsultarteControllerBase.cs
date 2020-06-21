using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Consultarte.Controllers
{
    public abstract class ConsultarteControllerBase: AbpController
    {
        protected ConsultarteControllerBase()
        {
            LocalizationSourceName = ConsultarteConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
