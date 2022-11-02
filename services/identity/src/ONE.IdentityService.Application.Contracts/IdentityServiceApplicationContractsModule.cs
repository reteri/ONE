using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;
using Volo.Abp.Identity;

namespace ONE.IdentityService;

[DependsOn(
    typeof(IdentityServiceDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
[DependsOn(typeof(AbpIdentityApplicationContractsModule))]
    public class IdentityServiceApplicationContractsModule : AbpModule
{

}
