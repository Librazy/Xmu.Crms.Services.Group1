﻿using Xmu.Crms.Services.Group1;
using Xmu.Crms.Shared.Service;

namespace Microsoft.Extensions.DependencyInjection
{ 
    public static class Group1Extensions
    {
        // 为每一个你写的Service写一个这样的函数，把 LoginService 替换为你实现的 Service
        public static IServiceCollection AddGroup1LoginService(this IServiceCollection serviceCollection)
        {
            return serviceCollection.AddScoped<ILoginService, LoginService>();
        }
    }
}
