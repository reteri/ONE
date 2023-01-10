using Volo.Abp.Modularity;

namespace ONE.PaymentService;

[DependsOn(
    typeof(PaymentServiceApplicationModule),
    typeof(PaymentServiceDomainTestModule)
    )]
public class PaymentServiceApplicationTestModule : AbpModule
{

}
