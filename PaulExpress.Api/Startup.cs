using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog;
using NsiTools.EfUtils.Core;
using NsiTools.EfUtils.Core.Interfaces;
using PaulExpress.Abstractions;
using PaulExpress.Abstractions.Repositories;
using PaulExpress.Abstractions.Services;
using PaulExpress.Api.Authentication;
using PaulExpress.Api.Swagger;
using PaulExpress.BusinessLogic.Services;
using PaulExpress.DataAccess;
using PaulExpress.DataAccess.Repositories;
using PaulExpress.Domain.Config;
using PaulExpress.Domain.Entities;

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
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
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
            services.AddDbContext<PaulExpressDBContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("PaulExpressDB")));

            services.SetupAuthentication(Configuration);
            
            //dependency injection
            services.AddScoped<IAuthorTraceability, WebAuthorTraceability>();
            services.AddScoped<IPaulExpressUnitOfWork, PaulExpressUnitOfWork>();

            //Repositories
            services.AddScoped<IOrderLineRepository, OrderLineRepository>();
            services.AddScoped<IOrderLineSupplementRepository, OrderLineSupplementRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IPaymentMethodRepository, PaymentMethodRepository>();
            services.AddScoped<ISandwichRepository, SandwichRepository>();
            services.AddScoped<ISauceRepository, SauceRepository>();
            services.AddScoped<IShopRepository, ShopRepository>();
            services.AddScoped<ISupplementRepository, SupplementRepository>();
            services.AddScoped<IOrderStatusRepository, OrderStatusRepository>();
            services.AddScoped<IUserRoleRepository, UserRoleRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IActionRepository, ActionRepository>();
            services.AddScoped<IActionRoleRepository, ActionRoleRepository>();

            //Services
            services.AddScoped<IReferentialService, ReferencialService>();
            services.AddScoped<ISandwichService, SandwichService>();
            services.AddScoped<IShopService, ShopService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IOrderService, OrderService>();


            services.AddScoped<IMapper, Mapper>();

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
