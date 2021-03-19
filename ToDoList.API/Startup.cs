using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System.Data.Common;
using ToDoList.Repository;
using Microsoft.OpenApi.Models;

namespace ToDoList.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        //Busca a string de conexão com o Banco de Dados
        public DbConnection DbConnection => new NpgsqlConnection(Configuration.GetConnectionString("App"));

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            //injeção de dependencia configurações que podem ser recuperadas depois
            services.AddCors();
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                //declada qual tipo de base que sera utilizada
                options.UseNpgsql(DbConnection,
                    //Declarande de onde vira as migrações
                    assembly => assembly.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));
            });

            DependencyInjection.Register(services);
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ToDoList.API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ToDoList.API v1"));

            }

            app.UseCors(builder => builder
               .AllowAnyHeader()
               .AllowAnyMethod()
               .SetIsOriginAllowed((host) => true)
               .AllowCredentials()
           );

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
