using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsCore.Models.Entities;
using WinFormsCore.Views;


namespace WinFormsCore.Services
{
    public static class ServiceConfigurator
    {
        public static ServiceProvider ConfigureServices(ServiceCollection services, IConfiguration configuration)
        {

            services.AddSingleton<IConfiguration>(configuration);

            services.AddDbContext<ShopContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<MainForm>();
            services.AddTransient<login>();

            // Apply pending migrations at startup
            var serviceProvider = services.BuildServiceProvider();
            using (var scope = serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ShopContext>();
                context.Database.Migrate(); 
            }
            return services.BuildServiceProvider();
        }
    }
}
