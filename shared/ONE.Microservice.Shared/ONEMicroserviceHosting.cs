using ONE.AdministrationService.EntityFrameworkCore;
using ONE.SaaSService.EntityFrameworkCore;
using ONE.Shared.Hosting;
using Volo.Abp.Modularity;

namespace ONE.Microservice.Shared
{
    [DependsOn(
    typeof(ONEHostingModule),
    typeof(AdministrationServiceEntityFrameworkCoreModule),
    typeof(SaaSServiceEntityFrameworkCoreModule)
)]
    public class ONEMicroserviceHosting : AbpModule
    {
    }
}
