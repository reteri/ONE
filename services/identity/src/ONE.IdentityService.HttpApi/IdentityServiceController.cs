using ONE.IdentityService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ONE.IdentityService;

public abstract class IdentityServiceController : AbpControllerBase
{
    protected IdentityServiceController()
    {
        LocalizationResource = typeof(IdentityServiceResource);
    }
}
