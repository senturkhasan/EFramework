using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFrameWork.Models
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();

            context.Database.Migrate();//initial dosysını calıştırmak için..(veridatabanı olusturulması)
            if(!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product() { Name="Prod1",Description="Proc Desc 1",Price=120,Category="Cat 1"},
                    new Product() { Name = "Prod2", Description = "Proc Desc 2", Price = 0, Category = "Cat 2" },
                    new Product() { Name = "Prod3", Description = "Proc Desc 3", Price = 140, Category = "Cat 3" }
                    );
                context.SaveChanges();
            }
            
        }
    }
}
