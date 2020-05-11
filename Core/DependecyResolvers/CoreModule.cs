using Core.CrossCuttingConcern.Caching;
using Core.CrossCuttingConcern.Caching.Microsoft;
using Core.Utilities.IoC;

using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Core.DependecyResolvers
{
    public class CoreModule:ICoreModule
    {
        public void Load(IServiceCollection services)
        {
            services.AddMemoryCache();//Cache operation
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();//Security operation
            services.AddSingleton<ICacheManager, MemoryCacheManager>();//Cache operation
            services.AddSingleton<Stopwatch>();
        }
    }
}
