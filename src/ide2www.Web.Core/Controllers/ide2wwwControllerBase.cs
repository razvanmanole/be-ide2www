using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ide2www.Controllers
{
    public abstract class ide2wwwControllerBase: AbpController
    {
        protected ide2wwwControllerBase()
        {
            LocalizationSourceName = ide2wwwConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
