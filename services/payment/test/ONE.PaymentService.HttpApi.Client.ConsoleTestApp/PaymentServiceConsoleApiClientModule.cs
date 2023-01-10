using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace ONE.PaymentService;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(PaymentServiceHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class PaymentServiceConsoleApiClientModule : AbpModule
{

}
