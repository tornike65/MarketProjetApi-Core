using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarketProj.DAL.Database;
using MarketProj.DAL.Repositories.Abstract;
using MarketProj.DAL.Repositories.Concrete;
using MarketProj.Services.Services.Abstract;
using MarketProj.Services.Services.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AutoMapper;
using MarketProj.Infrastructures;
using Microsoft.OpenApi.Models;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using MarketProj.Infrastructure.Helpers;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using MarketProj.DAL.Queries.ProductAgregate;
using MediatR;
using MarketProj.SignalRFiles;
using Microsoft.AspNetCore.SignalR;

namespace MarketProj
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
            services.AddCors();
            services.AddControllers();



            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Api", Version = "v1" });

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "JWT Authorization header using the Bearer scheme."
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                }
                            },
                            new string[] {}

                    }
                });
            });

            // configure strongly typed settings objects
            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);

            // configure jwt authentication
            var appSettings = appSettingsSection.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
                options.Events = new JwtBearerEvents()
                {
                     
                    OnMessageReceived = context =>
                      {
                          var accessToken = context.Request.Query["access_token"];
                          var path = context.HttpContext.Request.Path;
                          if (!string.IsNullOrEmpty(accessToken) && path.StartsWithSegments("/market-hub"))
                          {
                              context.Token = accessToken;
                          }

                          return Task.CompletedTask;
                      }
                };
            });

            services.AddSignalR(config =>
            {
                config.ClientTimeoutInterval = new TimeSpan(1, 0, 0);
                config.KeepAliveInterval = new TimeSpan(0, 30, 0);
            });

            services.AddSingleton<IUserIdProvider, NameUserIdProvider>();

            services.AddDbContext<MarketDB>(o =>
                o.UseSqlServer(Configuration.GetConnectionString("MarketDB")));

            services.AddDbContext<UsersDB>(o =>
                o.UseSqlServer(Configuration.GetConnectionString("UserDB")));

            services.AddDbContext<ChatDB>(o =>
                o.UseSqlServer(Configuration.GetConnectionString("ChatDB")));

            services.AddScoped<IUserService, UserService>();
            services.AddSingleton<ISignalRConnectionManeger, SignalRConnectionManeger>();
            services.AddSingleton<IHubNotificationHelper, HubNotificationHelper>();
            services.AddScoped<IAdminService, AdminService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IChatMessageService, ChatMessageService>();
            services.AddScoped<ITemporaryUserService, TemporaryUserService>();
            services.AddScoped<ITemporaryUserRepository, TemporaryUserRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IChatMessageRepository, ChatMessageRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IProductListItemRepository, ProductListItemRepository>();
            services.AddScoped<IProductItemListService, ProductItemListService>();
            services.AddMediatR(typeof(Startup));

            services.AddAutoMapper(typeof(AutoMaper));


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

            // global cors policy
            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());



            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endPoint =>
            {
                endPoint.MapHub<MarketHub>("/market-hub");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
