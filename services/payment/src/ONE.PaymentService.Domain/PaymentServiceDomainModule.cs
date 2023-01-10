using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace ONE.PaymentService;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(PaymentServiceDomainSharedModule)
)]
public class PaymentServiceDomainModule : AbpModule
{

}
