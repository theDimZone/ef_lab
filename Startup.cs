using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_LAb.Manager;
using EF_LAb.Manager.Interfaces;
using EF_LAb.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EF_LAb
{
    public class Startup
    {
        IConfigurationRoot _configurationRoot;
        /*
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        */
        public Startup(IHostingEnvironment hostingEnvironment)
        {
            _configurationRoot = new ConfigurationBuilder().SetBasePath(hostingEnvironment.ContentRootPath).AddJsonFile("appsettings.json").Build();
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddTransient<IMovieManager, MovieManager>();
            services.AddTransient<ICountryManager, CountryManager>();
            services.AddTransient<IActorManager, ActorManager>();
            services.AddTransient<IDirectorManager, DirectorManager>();
            services.AddTransient<IGenreManager, GenreManager>();
            services.AddTransient<ISelectionManager, SelectionManager>();
            services.AddTransient<IMediaManager, MediaManager>();

            //string connection = "Server=(localdb)\\mssqllocaldb;Database=mkdb;Trusted_Connection=True;";
            //services.AddDbContext<ModelsContext>(options => options.UseSqlServer(connection));
            //services.AddDbContext<ModelsContext>(options => {
            //    options.UseSqlServer(_configurationRoot.GetConnectionString("MikrokinopoiskDatabase"));
            //});

            services.AddDbContext<ModelsContext>();

            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}