using CoreApplication.Application.Interface;
using CoreApplication.Domain.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using CoreApplication.Infra.Data.Repository;
using CoreApplication.Application.Services;
namespace CoreApplication.Infra.IoC
{
   public class DependencyContainer
    {
        public static  void RegisterServices(IServiceCollection services)
        {
            //Application Layar
            services.AddScoped<ICourseService, CourseService>();

            //Infra service
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
