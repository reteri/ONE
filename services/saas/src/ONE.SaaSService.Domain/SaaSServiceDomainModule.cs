using Volo.Abp.Domain;
using Volo.Abp.Modularity;
using Volo.Abp.TenantManagement;

namespace ONE.SaaSService;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(SaaSServiceDomainSharedModule)
)]
[DependsOn(typeof(AbpTenantManagementDomainModule))]
    public class SaaSServiceDomainModule : AbpModule
{

}
