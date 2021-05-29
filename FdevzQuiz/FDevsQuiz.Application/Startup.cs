using FDevsQuiz.Domain.Interface;
using FDevsQuiz.Domain.Repository;
using FDevsQuiz.Infra.Data.Context;
using FDevsQuiz.Infra.Data.Repository;
using FDevsQuiz.Infra.Data.Repository.Base;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.OpenApi.Models;
using System;
using System.IO;

namespace FDevsQuiz
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
            services.AddScoped<IDbContext, DbContext>();

            services.AddScoped<IContatoRepository, ContatoRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IAlternativaRepository, AlternativaRepository>();
            services.AddScoped<INivelRepository, NivelRepository>();

            // Configurando o servi�o de documenta��o do Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "FDevs - Quiz",
                        Version = "v1",
                        Description = "FDevs - Quiz. Recursos disponiveis para implementa��o do QUIZ",
                        Contact = new OpenApiContact
                        {
                            Name = "Od�zio Pereira",
                            Url = new Uri("https://fdevs-quiz.com")
                        }
                    });
                c.CustomSchemaIds(x => x.FullName); //Essa linha deve ser inserida em casos que h� classes com mesmo nome em namespaces diferentes

                //Obtendo o diret�rio e depois o nome do arquivo .xml de coment�rios
                var applicationBasePath = PlatformServices.Default.Application.ApplicationBasePath;
                var applicationName = PlatformServices.Default.Application.ApplicationName;
                var xmlDocumentPath = Path.Combine(applicationBasePath, $"{applicationName}.xml");

                //Caso exista arquivo ent�o adiciona-lo
                if (File.Exists(xmlDocumentPath))
                    c.IncludeXmlComments(xmlDocumentPath);
            });

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            // Habilita o uso do Swagger
            app.UseSwagger();

            // Habilitar o middleware para servir o swagger-ui (HTML, JS, CSS, etc.), 
            // Especificando o Endpoint JSON Swagger.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "FDevs - Quiz");
                c.RoutePrefix = string.Empty; //Adicione algum proefixo da URL caso queira
            });
        }
    }
}
