using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
<<<<<<< HEAD:Calculator/Calculator/Startup.cs
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
=======
using Splitting.Repository;
using SplittingLogic.Model.Context;
using SplittingLogic.Repository.Implementations;
using SplittingLogic.Services;
using SplittingLogic.Services.Implementations;
>>>>>>> 05-SplittingLogic:SplittingLogic/SplittingLogic/Startup.cs

namespace SplittingLogic
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
<<<<<<< HEAD:Calculator/Calculator/Startup.cs
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Scaffold", Version = "v1" });
            });
=======

            var connection = Configuration["MySQLConnection:MySQLConnectionString"];
            services.AddDbContext<MySQLContext>(options => options.UseMySql(connection));

            //Versioning API 
            services.AddApiVersioning();

            //Dependency Injection
            services.AddScoped<IPersonService, PersonServiceImplementation>();
            services.AddScoped<IPersonRepository, PersonRepositoryImplementation>();
>>>>>>> 05-SplittingLogic:SplittingLogic/SplittingLogic/Startup.cs
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Scaffold v1"));
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
