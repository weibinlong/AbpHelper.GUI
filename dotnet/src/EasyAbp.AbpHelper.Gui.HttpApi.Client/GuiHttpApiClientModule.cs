﻿using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Account;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace EasyAbp.AbpHelper.Gui
{
    [DependsOn(
        typeof(GuiServiceContractsModule),
        typeof(AbpAccountHttpApiClientModule),
        typeof(AbpIdentityHttpApiClientModule)
    )]
    public class GuiHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "AbpHelperGui";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(GuiServiceContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
