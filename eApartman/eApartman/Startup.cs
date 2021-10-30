using eApartman.Database;
using eApartman.Model.Requests;
using eApartman.Security;
using eApartman.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eApartman
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
            services.AddAutoMapper(typeof(Startup));
            services.AddControllers()
                .AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "eProdaja API", Version = "v1" });

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

            services.AddDbContext<eApartmanContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("BackupDB")));
            
            services.AddScoped<ICRUDService<Model.Drzava, DrzavaSearchObject, DrzavaUpsertRequest, DrzavaUpsertRequest>, DrzaveService>();
            services.AddScoped<ICRUDService<Model.Grad, GradSearchObject, GradUpsertRequest, GradUpsertRequest>, GradService>();
            services.AddScoped<ICRUDService<Model.Adresa, AdresaSearchObject, AdresaUpsertRequest, AdresaUpsertRequest>, AdreseService>();
            services.AddScoped<ICRUDService<Model.Korisnik, KorisnikSearchObject, KorisnikInsertRequest, KorisnikUpdateRequest>, KorisniciService>();
            services.AddScoped<IKorisniciService, KorisniciService>();
            services.AddScoped<ICRUDService<Model.Apartman, ApartmanSearchObject, ApartmanUpsertRequest, ApartmanUpsertRequest>, ApartmaniService>();
            services.AddScoped<IReadService<Model.ApartmanTip, object>, BaseReadService<Model.ApartmanTip, object, ApartmanTip>>();
            services.AddScoped<ICRUDService<Model.ApartmanSlika, ApartmanSlikaSearchObject, List<ApartmanSlikaInsertRequest>, ApartmanSlikaInsertRequest>, SlikeService>();
            services.AddScoped<ICRUDService<Model.KorisnikUloga, object, Model.KorisnikUloga, object>, BaseCRUDService<Model.KorisnikUloga, KorisnikUloga, Model.KorisnikUloga, object, object>>();
            services.AddScoped<ICRUDService<Model.Korisnik, Model.VlasnikModerator, Model.VlasnikModerator, Model.VlasnikModerator>, ModeratoriService>();

            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
	   
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");              
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
