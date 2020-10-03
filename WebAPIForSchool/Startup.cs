using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebAPIForSchool.Data;

namespace WebAPIForSchool
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        
       
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers(); // we used only controllers for the web servis api

            services.AddDbContext<DatabaseContext>(opt => opt.UseSqlServer(
                Configuration.GetConnectionString("SchoolConnection")));

            //services.AddScoped<IStudent, MockStudentRepo>(); // For Dependency Injection
            services.AddScoped<IStudent, SqlStudentRepo>();
            //we defined Scoped if request come, we inject dependency

        }

        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

            });
        }
    }
}
