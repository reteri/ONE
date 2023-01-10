using ONE.PaymentService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ONE.PaymentService;

public abstract class PaymentServiceController : AbpControllerBase
{
    protected PaymentServiceController()
    {
        LocalizationResource = typeof(PaymentServiceResource);
    }
}
