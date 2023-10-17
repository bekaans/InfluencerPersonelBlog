using Blogger.Data.Context;
using Blogger.Data.Repositories.Abstraction;
using Blogger.Data.Repositories.Concretes;
using Blogger.Data.UnitOfWorks;
using Blogger.Service.Services.Abstraction;
using Blogger.Service.Services.Concretes;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogger.Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtensions(this IServiceCollection services)
        {
            services.AddScoped<IArticleService, ArticleService>();
            return services;
        }
    }
}
