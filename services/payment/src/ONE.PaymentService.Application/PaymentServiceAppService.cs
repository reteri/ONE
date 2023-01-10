﻿using ONE.PaymentService.Localization;
using Volo.Abp.Application.Services;

namespace ONE.PaymentService;

public abstract class PaymentServiceAppService : ApplicationService
{
    protected PaymentServiceAppService()
    {
        LocalizationResource = typeof(PaymentServiceResource);
        ObjectMapperContext = typeof(PaymentServiceApplicationModule);
    }
}
