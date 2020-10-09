using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Cookbook.Model.Requests;
using Cookbook.WebAPI.Database;
using Cookbook.WebAPI.Filters;
using Cookbook.WebAPI.Security;
using Cookbook.WebAPI.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.Swagger;

namespace Cookbook.WebAPI
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
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Cookbook API", Version = "v1" });

                c.AddSecurityDefinition("basicAuth", new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic"
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "basicAuth" }
                        },
                        new string[]{}
                    }
                });
            });

          services.AddMvc
             (x => x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddControllers();
            /*  services.AddMvc(config => {
                  var policy = new AuthorizationPolicyBuilder()
                     .AddAuthenticationSchemes(new[] { BasicAuthenticationDefaults.AuthenticationScheme })
                     .AddRequirements(new BasicAuthorizationRequirement())
                     .Build();
                  config.Filters.Add(new AuthorizeFilter(policy));
              });*/

            /*    services.AddMvc(config =>
                {
                    var policy = new AuthorizationPolicyBuilder()
                                 .RequireAuthenticatedUser()
                                 .Build();
                    config.Filters.Add(new AuthorizeFilter(policy));
                });*/

            //  services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddAutoMapper(typeof(Startup));
            
            services.AddAuthentication("BasicAuthentication")
             .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);
            services.AddScoped<IService<Model.Uloga, object>, BaseService<Model.Uloga, object, Uloga>>();
            services.AddScoped<IPreporukaService, PreporukaService>();
            services.AddScoped<IKorisnikService, KorisnikService>();
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IKupacService, KupacService>();
            services.AddScoped<ICRUDService<Model.Sastojak, SastojakSearchRequest,SastojakInsertRequest, SastojakInsertRequest>, SastojakService>();
            services.AddScoped<ICRUDService<Model.Kategorija,KategorijaSearchRequest,KategorijaInsertRequest,KategorijaInsertRequest>,KategorijaService>();
            services.AddScoped<ICRUDService<Model.MjernaJedinica, MjernaJedinicaSearchRequest, MjernaJedinicaInsertRequest, MjernaJedinicaInsertRequest>, MjernaJedinicaService>();
            services.AddScoped<ICRUDService<Model.GrupaJela, GrupaJelaSearchRequest, GrupaJelaUpsertRequest, GrupaJelaUpsertRequest>, GrupaJelaService>();
            services.AddScoped<ICRUDService<Model.Slozenost, SlozenostSearchRequest, SlozenostUpsertRequest, SlozenostUpsertRequest>, SlozenostService>();
            services.AddScoped<ICRUDService<Model.MjernaKolicina, MjernaKolicinaSearchRequest, MjernaKolicinaUpsertRequest, MjernaKolicinaUpsertRequest>, MjernaKolicinaService>();
            services.AddScoped<ICRUDService<Model.VrstaClanka, VrstaClankaSearchRequest, VrstaClankaInsertRequest, VrstaClankaInsertRequest>, VrstaClankaService>();
            services.AddScoped<ICRUDService<Model.Clanak, ClanakSearchRequest, ClanakInsertRequest, ClanakInsertRequest>, ClanakService>();
            services.AddScoped<ICRUDService<Model.Recept, ReceptSearchRequest, ReceptUpsertRequest, ReceptUpsertRequest>, ReceptService>();
            services.AddScoped<ICRUDService<Model.ReceptSastojak, ReceptSastojakSearchRequest, ReceptSastojakUpsertRequest, ReceptSastojakUpsertRequest>, ReceptSastojakService>();
            services.AddScoped<IDokumentService, DokumentService>();
            services.AddScoped<ICRUDService<Model.Favoriti, FavoritiSearchRequest, FavoritiUpsertRequest, FavoritiUpsertRequest>, FavoritiService>();
            services.AddScoped<ICRUDService<Model.Komentar, KomentarSearchRequest, KomentarUpsertRequest, KomentarUpsertRequest>, KomentarService>();
            services.AddScoped<ICRUDService<Model.Ocjena, OcjenaSearchRequest, OcjenaUpsertRequest, OcjenaUpsertRequest>, OcjenaService>();
            services.AddScoped<ICRUDService<Model.Notifikacija, NotifikacijaSearchRequest, NotifikacijaUpsertRequest, NotifikacijaUpsertRequest>, NotifikacijaService>();
            var connection = @"data source =.; initial catalog = Cookbook; integrated security = True;";
            services.AddDbContext<CookbookContext>(options => options.UseSqlServer(connection));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
            public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
        
            // app.UseHttpsRedirection();

            app.UseSwagger();
      
            app.UseRouting();
            app.UseHttpsRedirection();

            app.UseAuthentication();

            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");

            });
        }
    }
}
