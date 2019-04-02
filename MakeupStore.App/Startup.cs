using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MakeupStore.BLL;
using Microsoft.EntityFrameworkCore;
using MakeupStore.DataAccess;

namespace MakeupStore.App
{
    public class Startup
    {

        private static void SeedDatabase()
        {

        }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            SeedDatabase();
        }

        // this config objects is pulled from many sources by default...
        // appsettings.json, appsettings.Development.json, environment variables,
        // user secrets (how we will put connection string.).
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //this needs to call the interface and then the dbrepository
            services.AddScoped<IInventoryRepository, InventoryDbRepository>();
            services.AddScoped<ICustomerRepository, CustomerDbRepository>();
            services.AddScoped<ILocationRepository, LocationDbRepository>();
            services.AddScoped<IOrderRepository, OrderDbRepository>();
            services.AddScoped<IOrderItemRepository, OrderItemDbRepository>();


            //services.AddSingleton<IList<Inventory>>(_inventoryDb);


            services.AddDbContext<MakeupStoreDbContext>(builder =>
                builder.UseSqlServer(Configuration.GetConnectionString("ConnectionString")));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}