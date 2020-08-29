using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

using Microsoft.AspNetCore.Authentication.Cookies;

using Sufrati_backEnd.API.Configurations;

namespace Sufrati_backEnd
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

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
          .AddJwtBearer(options =>
          {
              options.RequireHttpsMetadata = false;
              options.SaveToken = true;
              options.TokenValidationParameters = new TokenValidationParameters
              {
                  ValidateIssuer = false,
                  ValidateAudience = false,
                  ValidateLifetime = true,
                  ValidateIssuerSigningKey = true,

                  IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("VaibhavBhapkarlkdfhjkfdm;lofdkkndbsdjnj")),
                  ClockSkew = TimeSpan.Zero
              };
          }).AddCookie("cookies", option =>
          {
              option.Cookie.Name = "auth_cookie";
              option.Cookie.SameSite = SameSiteMode.None;
              option.Events = new CookieAuthenticationEvents
              {
                  OnRedirectToLogin = redirectContext =>
                  {
                      redirectContext.HttpContext.User = null;
                      redirectContext.HttpContext.Response.StatusCode = 401;
                      return Task.CompletedTask;
                  }
              };
          });
            services.AddMvc();
            services.AddSwaggerGen();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.ConfigureRepositories()
          .ConfigureSupervisor()
          //.AddCorsConfiguration()
          .AddMiddleware()
          .ConfigureMapper()
          .AddConnection(Configuration)
          .AddAppSettings(Configuration);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
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
