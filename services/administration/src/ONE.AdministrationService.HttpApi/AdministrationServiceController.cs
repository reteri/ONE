using ONE.AdministrationService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ONE.AdministrationService;

public abstract class AdministrationServiceController : AbpControllerBase
{
    protected AdministrationServiceController()
    {
        LocalizationResource = typeof(AdministrationServiceResource);
    }
}
