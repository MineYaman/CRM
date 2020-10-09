using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRM.Business.Abstract;
using CRM.Business.Concrete;
using CRM.DataAccess.Abstract;
using CRM.DataAccess.Concrete.EfCore;
using CRM.WebUI.EmailServices;
using CRM.WebUI.Identity;
using CRM.WebUI.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CRM.WebUI
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationIdentityDbContext>(options =>
             options.UseSqlServer(Configuration.GetConnectionString("IdentityConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationIdentityDbContext>()
                .AddDefaultTokenProviders();


            services.Configure<IdentityOptions>(options =>
            {
                // password

                options.Password.RequireDigit = true; //Şifre içinde mutlaka sayı olmalı
                options.Password.RequireLowercase = true; //Şifre içinde mutlaka küçük harf olmalı
                options.Password.RequiredLength = 8; //En az 8 karakterli olmalı
                options.Password.RequireNonAlphanumeric = true; //Alphanumeric değer olmasa da olur
                options.Password.RequireUppercase = true; ////Şifre içinde mutlaka büyük harf olmalı

                options.Lockout.MaxFailedAccessAttempts = 5; //Kullanıcı şifreyi max 5 kere hatalı girebilir
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5); //5 dk boyunca şifre giremeyecek
                options.Lockout.AllowedForNewUsers = true; //Yeni kullanıcı içinde kilitleme işlemi olcak

                // options.User.AllowedUserNameCharacters = "";
                options.User.RequireUniqueEmail = true; //Mailler unique olmalı

                options.SignIn.RequireConfirmedEmail = true; //Hesap oluşturduktan sonra onay işlemi yapmalı.
                options.SignIn.RequireConfirmedPhoneNumber = false;
            });

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/account/login";
                options.LogoutPath = "/account/logout";
                options.AccessDeniedPath = "/account/accessdenied"; //Kullanıcının erişim hakkının olmadığı durumlarda yönlendirme işlemi
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60); //Cookie 60 dk boyunca geçerli sayılır
                options.SlidingExpiration = true;
                options.Cookie = new CookieBuilder
                {
                    HttpOnly = true, //Sadece http talepleriyle cookie okunur. Kullanıcı güvenliği için
                    Name = ".CRM.Security.Cookie",
                    SameSite = SameSiteMode.Strict
                };

            });

            services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_2_2);

            services.AddScoped<IDepartmentDal, EfCoreDepartmentDal>();
            services.AddScoped<IDepartmentService, DepartmentManager>();

            services.AddScoped<IJobDal, EfCoreJobDal>();
            services.AddScoped<IJobService, JobManager>();

            services.AddScoped<IUserDal, EfCoreUserDal>();
            services.AddScoped<IUserService, UserManager>();

            services.AddScoped<IDepartmentStaffDal, EfCoreDepartmentStaffDal>();
            services.AddScoped<IDepartmentStaffService, DepartmentStaffManager>();

            services.AddScoped<IDepartmentAttendantDal, EfCoreDepartmentAttendantDal>();
            services.AddScoped<IDepartmentAttendantService, DepartmentAttendantManager>();

            services.AddScoped<IDepartmentJobDal, EfCoreDepartmentJobDal>();
            services.AddScoped<IDepartmentJobService, DepartmentJobManager>();

            services.AddTransient<IEmailSender, EmailSender>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                SeedDatabase.Seed();
            }

            app.UseStaticFiles();
            app.CustomStaticFiles();
            app.UseAuthentication();
            app.UseMvcWithDefaultRoute();

            SeedIdentity.Seed(userManager, roleManager, Configuration).Wait();
        }
    }
}
