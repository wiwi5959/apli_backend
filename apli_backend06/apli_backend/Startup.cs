using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace apli_backend
{

    using Models;
    using Repositories;
    using Repositories.Impl;
    using Services;
    using Services.Impl;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Cette méthode permet de rajouter les services pour l'injection de dépendances 
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<PersonneService, PersonneImplService>();
            services.AddSingleton<PersonneRepository, PersonneListRepository>();

            services.AddSingleton<VoitureService, VoitureImplService>();
            services.AddSingleton<VoitureRepository, VoitureListRepository>();

            services.AddControllers();
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
