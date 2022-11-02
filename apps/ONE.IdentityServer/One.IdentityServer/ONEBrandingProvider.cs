using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ONE.IdentityServer
{
    [Dependency(ReplaceServices = true)]
    public class ONEBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "ONE";
    }
}
