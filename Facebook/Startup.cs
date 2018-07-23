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
using Facebook.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Facebook.Models;
using Microsoft.AspNet.Identity;

namespace Facebook
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        FacebookOptions fso = new FacebookOptions();
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
            services.AddDefaultIdentity<IdentityUser>()
                .AddEntityFrameworkStores<ApplicationDbContext>();
            ///
            services.AddIdentity<ApplicationUser, IdentityRole>()
             .AddEntityFrameworkStores<ApplicationDbContext>()
             .AddDefaultTokenProviders();

            services.AddAuthentication().AddFacebook(facebookOptions =>
            {
                facebookOptions.AppId = "1597162847038158";//Configuration["Authentication:Facebook:AppId"]; -- добавить потом значение в секреты
                facebookOptions.AppSecret = "1b41ced56c30b5b43159664578e2586f";//Configuration["Authentication:Facebook:AppSecret"]; -- добавить потом значение в секреты
            });
            services.ConfigureApplicationCookie(identityOptionsCookies =>
            {
                identityOptionsCookies.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
            });
            services.AddAuthentication()
             //.AddMicrosoftAccount(microsoftOptions => { ... })
             //.AddGoogle(googleOptions => { ... })
             //.AddTwitter(twitterOptions => { ... })
             .AddFacebook(facebookOptions => { fso.AppId=facebookOptions.AppId;
                 fso.AppSecret = facebookOptions.AppSecret;
                 ////fso.AuthenticationScheme = facebookOptions.AuthenticationScheme;
                 fso.AuthorizationEndpoint = facebookOptions.AuthorizationEndpoint;
                 ////fso.AutomaticChallenge = facebookOptions.AutomaticChallenge;
                 fso.BackchannelHttpHandler = facebookOptions.BackchannelHttpHandler.ToString();
                 fso.BackchannelTimeout = facebookOptions.BackchannelTimeout;
                 fso.CallbackPath = facebookOptions.CallbackPath;
                 fso.ClaimsIssuer = facebookOptions.ClaimsIssuer;
                 fso.ClientId = facebookOptions.ClientId;
                 fso.ClientSecret = facebookOptions.ClientSecret;
                 ////fso.Description = facebookOptions.Description;
                 ////fso.DisplayName = facebookOptions.DisplayName;
                 fso.Events = facebookOptions.Events.ToString();
                 ////fso.Fields = facebookOptions.Fields;
                 fso.RemoteAuthenticationTimeout = facebookOptions.RemoteAuthenticationTimeout;
                 ////fso.Scope = facebookOptions.Scope;
                 fso.SendAppSecretProof = facebookOptions.SendAppSecretProof;
                 fso.SignInScheme = facebookOptions.SignInScheme;
                 ////fso.StateDataFormat = facebookOptions.StateDataFormat;
                 ////fso.SystemClock = facebookOptions.SystemClock;
                 fso.TokenEndpoint = facebookOptions.TokenEndpoint;
                 fso.UserInformationEndpoint = facebookOptions.UserInformationEndpoint;
             });


            ///
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
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
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
