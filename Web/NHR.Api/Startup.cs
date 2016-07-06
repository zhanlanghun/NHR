using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Autofac;
using NHR.IRepository;
using NHR.Repository;
using NHR.Service;
using Autofac.Extensions.DependencyInjection;

namespace NHR.Api
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            if (env.IsEnvironment("Development"))
            {
                // This will push telemetry data through Application Insights pipeline faster, allowing you to view results immediately.
                builder.AddApplicationInsightsSettings(developerMode: true);
            }

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddApplicationInsightsTelemetry(Configuration);

            services.AddMvc();
           return Ioc(services);
          
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseApplicationInsightsRequestTelemetry();

            app.UseApplicationInsightsExceptionTelemetry();

            app.UseMvc();
            
        }
        private IServiceProvider Ioc(IServiceCollection services)
        {
            var containerBuilder = new ContainerBuilder();
            //自动注册仓库
            containerBuilder.RegisterAssemblyTypes(Assembly.Load(new AssemblyName("NHR.IRepository")), Assembly.Load(new AssemblyName("NHR.Repository"))).Where(p => p.FullName.EndsWith("Repository")).AsImplementedInterfaces();
            //注册服务为自己
            containerBuilder.RegisterAssemblyTypes(Assembly.Load(new AssemblyName("NHR.Service"))).Where(p => p.FullName.EndsWith("Service")).AsSelf();
           
            containerBuilder.Populate(services);
            var container = containerBuilder.Build();
            return container.Resolve<IServiceProvider>();
        }
    }
}
