using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Message.Models;
using System;
using System.Reflection;
using System.IO;
using Microsoft.OpenApi.Models;

namespace Message
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

            services.AddDbContext<MessageContext>(opt =>
                opt.UseMySql(Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(Configuration["ConnectionStrings:DefaultConnection"])));
            services.AddControllers();
            services.AddSwaggerGen(c =>
{
            c.SwaggerDoc("v1", new OpenApiInfo
            {
                Version = "v1",
                Title = "Message! API",
                Description = "A simple messageboard ASP.NET Core Web API",
                TermsOfService = new Uri("https://thiswebsiteisalie.com/thispathdontexist"),
                Contact = new OpenApiContact
                {
                    Name = "Dr. Bellsahcké",
                    Email = string.Empty,
                    Url = new Uri("https://nowhere.com/lieslieslies"),
                },
                License = new OpenApiLicense
                {
                    Name = "Use under GPL",
                    Url = new Uri("https://nothingtoseeherefolks.com/nadanowaynohow"),
                }
            });
        });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = string.Empty;
            });

            // app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}