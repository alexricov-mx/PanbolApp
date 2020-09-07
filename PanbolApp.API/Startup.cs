using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PanbolApp.Core.Interfaces.Repository;
using PanbolApp.Infraestructura.Repository;
using Serilog;

namespace PanbolApp.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            //Establece el uso de Serilog con su configuración establecida en appsettings.json
            Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(configuration).CreateLogger();

            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            //Configura el uso de Swagger en el proyecto
            services.AddSwaggerGen();

            services.AddTransient<IPanbolAppRepository>(s => new PanbolAppRepository(Configuration["ConnectionStrings:FirebaseURL"], Configuration["ApiKeys:FirebaseApiKey"], Configuration["Credenciales:FirebaseUser"], Configuration["Credenciales:FirebasePwd"]));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Inicio de configuración uso de Swagger
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "eSing API V1");
            });

            app.UseStaticFiles();
            //Fin de configuración de Swagger

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
