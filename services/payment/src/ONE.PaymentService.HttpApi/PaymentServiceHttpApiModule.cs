using Localization.Resources.AbpUi;
using ONE.PaymentService.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace ONE.PaymentService;

[DependsOn(
    typeof(PaymentServiceApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class PaymentServiceHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(PaymentServiceHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<PaymentServiceResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
