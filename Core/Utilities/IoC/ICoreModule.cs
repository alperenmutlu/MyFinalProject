using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.IoC
{
    //bu bizim framework katmanımız
    public interface ICoreModule
    {
        void Load(IServiceCollection serviceCollection);
    }
}
