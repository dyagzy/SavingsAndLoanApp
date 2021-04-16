using AdyMfb.Controllers;
using EntityLayer.AdminRepository;
using EntityLayer.AutoMapperProfile;
using EntityLayer.CustomerRepository;
using EntityLayer.CustomerRepositoryServices;
using EntityLayer.DataAccess;
using EntityLayer.IAdminRepositorys;
using EntityLayer.SavingsRepository;
using EntityLayer.SavingsRepository.ISavingsRepositorys;
using EntityLayer.Service.SmS;
using EntityLayer.SignUp.Configuration;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Twilio.Clients;

namespace AdyMfb
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.

        //ioc container(inversion of control)
        public void ConfigureServices(IServiceCollection services)
        {


            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddAutoMapper(typeof(CustomerMapper));
            services.AddAutoMapper(typeof(SavingsAccountMapper));
            services.AddAutoMapper(typeof(LoanMapper));
            services.AddAutoMapper(typeof(DepositMapper));
            


            services.AddScoped<ISavingsRepository, SavingsRepo>();
            services.AddScoped<ICustomerRepository, CustomerService>();

            services.AddScoped<IAdminRepository, AdminRepositoryImplementation>();
           // services.AddHttpClient<ITwilioRestClient, TwilioClient>();
          

            services.Configure<JwtConfig>(Configuration.GetSection("JwtConfig"));

            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;


            }).AddJwtBearer(jwt =>
            {
                var key = Encoding.ASCII.GetBytes(Configuration["JwtConfig:Secret"]);
                jwt.SaveToken = true;
                jwt.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    RequireExpirationTime = false
                };

            });

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                
               .AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

            services.AddSwaggerGen(c =>
            {
              c.SwaggerDoc("v1", new OpenApiInfo { Title = "AdyMfb", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AdyMfb v1"));
            }

            app.UseHttpsRedirection();

            app.UseCors("AllowEverthing");
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
