﻿using Core.Utilities.IOC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DependencyResolvers
{
    public class CoreModule:ICoreModule
    {
        public void load(IServiceCollection serrviceCollection)
        {
            serrviceCollection.AddMemoryCache();
            serrviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //serrviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>();
        }
    }
}
