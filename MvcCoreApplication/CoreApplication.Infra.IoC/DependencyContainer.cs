using CoreApplication.Application.Interface;
using CoreApplication.Domain.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using CoreApplication.Infra.Data.Repository;
using CoreApplication.Application.Services;
using CoreApplication.Domain.Core.Bus;
using CoreApplication.Infra.Bus;
using MediatR;
using CoreApplication.Domain.Commands;
using CoreApplication.Domain.CommandHandlers;
using CoreApplication.Infra.Data.Context;

namespace CoreApplication.Infra.IoC
{
   public class DependencyContainer
    {
        public static  void RegisterServices(IServiceCollection services)
        {

            // Domain InMemoryBus MediatR 
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            //Domain Handlers
            services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>();

            //Application Layar
            services.AddScoped<ICourseService, CourseService>();

            //Infra service
            services.AddScoped<ICourseRepository, CourseRepository>();

            services.AddScoped<UniversityDBContext>();
        }
    }
}
