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
using NLog;
using PaulExpress.Api.Authentication;
using PaulExpress.Api.Swagger;
using PaulExpress.Domain.Config;

namespace PaulExpress.Api
{
    public class Startup
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddHttpContextAccessor();
            services.AddMemoryCache();
            services.AddSwaggerDocumentation();
            services.AddCors(opt => opt.AddDefaultPolicy(builder =>
            {
                var origins = Configuration.GetSection("AllowedOrigins").Get<string[]>();
                _logger.Debug($"Allowed origins [${string.Join(", ", origins)}]");
                builder.WithOrigins(origins);
                builder.AllowAnyHeader();
                builder.AllowAnyMethod();
            }));

            IConfigurationSection appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);

            services.SetupAuthentication(Configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwaggerDocumentation();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API"));
        }
    }
}
