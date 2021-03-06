using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ComiAdminn.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ComiCore;
using ComiService.Interfaces;
using ComiService.Implementations;
using AutoMapper;
using Microsoft.Extensions.FileProviders;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

namespace ComiAdminn
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<ApplicationUser>().AddRoles<ApplicationRole>()
                    .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddAuthentication();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            Mapper.Initialize(cfg => {
                cfg.AddProfile<ComiProfile>();
            });
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new ComiProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                                 .RequireAuthenticatedUser()
                                 .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            }).AddRazorPagesOptions(options =>
            {
                options.Conventions.AuthorizePage("/Contact");
                options.Conventions.AuthorizeFolder("/Private");
                options.Conventions.AllowAnonymousToPage("/Private/PublicPage");
                options.Conventions.AllowAnonymousToFolder("/Private/PublicPages");
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddAuthorization();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseFileServer(new FileServerOptions()
            {
                FileProvider = new PhysicalFileProvider(Configuration["Image"]),
                RequestPath = new PathString("/img"),
                EnableDirectoryBrowsing = false
            });
            app.UseCookiePolicy();

            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
