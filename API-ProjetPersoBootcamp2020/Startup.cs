using Api_ModelClient.Services;
using Bibliotheque_Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using ToolBox;
using GNovelsService = Api_ModelGobal.Services.NovelsService;
using GNovel = Api_ModelGobal.Entities.Novels;
using GSeriessService = Api_ModelGobal.Services.SeriesService;
using GSerie = Api_ModelGobal.Entities.Series;
using GType = Api_ModelGobal.Entities.Types;
using GTypesService = Api_ModelGobal.Services.TypesService;
using GUser = Api_ModelGobal.Entities.User;
using GUserService = Api_ModelGobal.Services.UserService;
using Api_ModelClient.Entities;

namespace API_ProjetPersoBootcamp2020
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

            services.AddControllers()
                .AddXmlDataContractSerializerFormatters();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API_ProjetPersoBootcamp2020", Version = "v1" });
            });
            DBConnectionInfo connectionInfo = new DBConnectionInfo(@"Data Source=(localdb)\Test;Initial Catalog=BootCamp-Books;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            services.AddSingleton<IConnection>(sp => new DBConnection(connectionInfo,SqlClientFactory.Instance ));
            services.AddSingleton<INovelsService<GNovel>,GNovelsService>();
            services.AddSingleton<INovelsService<Novels>,NovelsService>();
            services.AddSingleton<ISeriesService<GSerie>, GSeriessService>();
            services.AddSingleton<ISeriesService<Series>, SeriesService>();
            services.AddSingleton<ITypesRepo<GType>, GTypesService>();
            services.AddSingleton<ITypesRepo<Types>, TypesService>();            
            services.AddSingleton<IUserService<GUser>, GUserService>();
            services.AddSingleton<IUserService<User>, UserService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API_ProjetPersoBootcamp2020 v1"));
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
