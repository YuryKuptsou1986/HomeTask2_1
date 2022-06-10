using CartService.BLL.Mappings;
using CartService.BLL.Services;
using CartService.DAL.Interfaces;
using CartService.DAL.LiteDb.DbContext;
using CartService.DAL.LiteDb.Providers;
using CartService.DAL.LiteDb.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CartService
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
            services.AddScoped<ILiteDbSettingsProvider, LiteDbSettingsProvider>();
            services.AddScoped<ILiteDBContext, LiteDBContext>();
            services.AddScoped<ICartRepository, CartRepository>();
            services.AddScoped<ICartService, BLL.Services.CartService>();

            services.AddAutoMapper(typeof(AppMappingProfile));

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }
    }
}
