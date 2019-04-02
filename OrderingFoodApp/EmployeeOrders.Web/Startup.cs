using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeOrders.Web.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeOrders.Web
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
			//he instance required by the parameters will be created automatically by the dependency injection container.
			services.AddDbContext<EmployeeOrdersContext>();
			services.AddMvc();
			services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
				.AddCookie(option => {
					option.LoginPath = "/User/LogIn";
					option.AccessDeniedPath = "/Error/AccessDenied";
					option.Cookie.SecurePolicy = CookieSecurePolicy.Always;
				});
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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

			app.UseExceptionHandler("/Error/Index");
			app.UseStaticFiles();
			app.UseAuthentication();
			app.UseMvcWithDefaultRoute();
		}
	}
}
