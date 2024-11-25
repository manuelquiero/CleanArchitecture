using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain
{
    public static class DependencyInjection
    {
        public static IServiceCollection DomainDI(this IServiceCollection service)
        {
            return service;
        }
    }
}
