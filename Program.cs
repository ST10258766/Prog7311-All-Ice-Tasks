<<<<<<< HEAD
using SolidOrderProcessing.Models;

namespace SolidOrderProcessing
=======
﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TaskManager.Data;
namespace TaskManager
>>>>>>> 0b32b568913dd742e9ab80fc8b6efe6b0c7d873e
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
<<<<<<< HEAD
=======
            //USING Sql Server
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
     options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")
          ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.")));
>>>>>>> 0b32b568913dd742e9ab80fc8b6efe6b0c7d873e

            // Add services to the container.
            builder.Services.AddControllersWithViews();

<<<<<<< HEAD
            // Dependency injection registrations
            builder.Services.AddScoped<INotificationFactory, NotificationFactory>();
            builder.Services.AddScoped<SmsNotificationService>();
            builder.Services.AddScoped<EmailNotificationService>();
=======
            
           
>>>>>>> 0b32b568913dd742e9ab80fc8b6efe6b0c7d873e

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
<<<<<<< HEAD
        
       
=======
>>>>>>> 0b32b568913dd742e9ab80fc8b6efe6b0c7d873e
    }
}
