using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.IOC
{
    public interface ICoreModule
    {
        void load(IServiceCollection serrviceCollection);
    }
}
