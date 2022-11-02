using Localization.Resources.AbpUi;
using Microsoft.Extensions.DependencyInjection;
using ONE.AdministrationService.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.SettingManagement;

namespace ONE.AdministrationService;

[DependsOn(
    typeof(AdministrationServiceApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
[DependsOn(typeof(AbpFeatureManagementHttpApiModule))]
[DependsOn(typeof(AbpPermissionManagementHttpApiModule))]
[DependsOn(typeof(AbpSettingManagementHttpApiModule))]
public class AdministrationServiceHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(AdministrationServiceHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<AdministrationServiceResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
