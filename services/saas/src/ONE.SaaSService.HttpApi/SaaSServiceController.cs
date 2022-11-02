using ONE.SaaSService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ONE.SaaSService;

public abstract class SaaSServiceController : AbpControllerBase
{
    protected SaaSServiceController()
    {
        LocalizationResource = typeof(SaaSServiceResource);
    }
}
