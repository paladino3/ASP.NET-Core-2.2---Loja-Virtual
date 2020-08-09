using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Database;
using LojaVirtual.Repository;
using LojaVirtual.Repository.Contracts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LojaVirtual
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

       
        public void ConfigureServices(IServiceCollection services)
        {
            /*
             *PADRAO REPOSITORY
            */
            services.AddScoped<IClienteRepository, ClienteRpository>(); //injetando a dependencia dos serviços
            services.AddScoped<INewsLetterRepository, NewsLetterRepository>(); //injetando a dependencia dos serviços
            services.AddScoped<IFuncionarioRepository, FuncionarioRepository>(); //injetando a dependencia dos serviços
            services.Configure<CookiePolicyOptions>(options =>
            {
               
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            string connection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LojaVirtual;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            services.AddDbContext<LojaVirtualContext>(options => options.UseSqlServer(connection));
        }

       
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
            app.UseDefaultFiles(); // direciona automaticamente para o index.html
            app.UseStaticFiles(); // usa as classe staticas de wwwroot, como bootstrap, css etc
            app.UseCookiePolicy();


            /*
             * https://www.site.com.br -> Qual controlador? (gestao) -> Rotas
             * https://www.site.com.br/Produtos/Visualizar/MouseRazerZk
             * https://www.site.com.br/Produtos/Visualizar -> Listagem de todos os produtos (? opcional)
             *
             * https://www.site.com.br -> https://www.site.com.br/Index
             * https://www.site.com.br -> https://www.site.com.br/Produto/Index
            */



            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
