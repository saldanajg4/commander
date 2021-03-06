using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Commander.data;
using Commander.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Commander
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        //AddScoped will create one connection to source per client request
        //If needs to change we only change the MockCommanderRepo concrete class
        public void ConfigureServices(IServiceCollection services)
        {
            var builder = new SqlConnectionStringBuilder();
            builder.ConnectionString =Configuration.GetConnectionString("CommanderConnection");
            builder.UserID= Configuration["UserID"];
            builder.Password = Configuration["Password"];

            services.AddDbContext<CommanderContext>(opt => opt.UseSqlServer
                // (Configuration.GetConnectionString("CommanderConnection"))
                (builder.ConnectionString)
            );


            services.AddControllers();
            services.AddScoped<ICommanderRepo, DbCommanderRepo>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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
