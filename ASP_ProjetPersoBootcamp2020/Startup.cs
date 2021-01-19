using Asp_ModelClient.Entities;
using Asp_ModelClient.Services;
using GNovels = Asp_ModelGlobal.Entities.Novels;
using GNovelsService = Asp_ModelGlobal.Services.NovelsService;
using GSerie = Asp_ModelGlobal.Entities.Series;
using GSeriesService = Asp_ModelGlobal.Services.SeriesService;
using Gtype = Asp_ModelGlobal.Entities.Types;
using GtypeService = Asp_ModelGlobal.Services.TypesService;
using GUser = Asp_ModelGlobal.Entities.User;
using GUserService = Asp_ModelGlobal.Services.UserService;

using Bibliotheque_Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ASP_ProjetPersoBootcamp2020
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
            services.AddControllersWithViews();
            //services.AddDistributedMemoryCache();
            //services.AddHttpContextAccessor();
            //services.AddSession(options =>
            //{
            //    options.IdleTimeout = TimeSpan.FromSeconds(3600);
            //    options.Cookie.HttpOnly = true;
            //    options.Cookie.IsEssential = true;
            //});
            services.AddTransient(sp =>
            {
                HttpClient client = new HttpClient() { BaseAddress = new Uri("http://localhost:62814") };
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                return client;
            });
            // Attention : le service du modelClient doit pointer sur le meme entitie (client ou global)
            services.AddScoped<INovelsService<GNovels>,GNovelsService>();
            services.AddScoped<INovelsService<Novels>,NovelsService>();

            services.AddScoped<ISeriesService<GSerie>, GSeriesService>();
            services.AddScoped<ISeriesService<Series>, SeriesService>();

            services.AddScoped<ITypesService<Gtype>, GtypeService>();
            services.AddScoped<ITypesService<Types>, TypesService>();

            services.AddScoped<IUserService<GUser>, GUserService>();
            services.AddScoped<IUserService<User>, UserService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
