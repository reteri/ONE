using ONE.AdministrationService;
using ONE.AdministrationService.EntityFrameworkCore;
using ONE.IdentityService;
using ONE.IdentityService.EntityFrameworkCore;
using ONE.SaaSService;
using ONE.SaaSService.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ONE.DbMigrator
{
    [DependsOn(
    typeof(AbpAutofacModule),
    typeof(AdministrationServiceEntityFrameworkCoreModule),
    typeof(AdministrationServiceApplicationContractsModule),
    typeof(IdentityServiceEntityFrameworkCoreModule),
    typeof(IdentityServiceApplicationContractsModule),
    typeof(SaaSServiceEntityFrameworkCoreModule),
    typeof(SaaSServiceApplicationContractsModule)
    //typeof(ONEHostingModule)
        )]
    public class ONEDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            //Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
