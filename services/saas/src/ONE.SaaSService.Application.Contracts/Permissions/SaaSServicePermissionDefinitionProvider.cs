﻿using ONE.SaaSService.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ONE.SaaSService.Permissions;

public class SaaSServicePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SaaSServicePermissions.GroupName, L("Permission:SaaSService"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SaaSServiceResource>(name);
    }
}
