using MBShopApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBShopApp.DataAccess.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context=new ShopContext();
            if (context.Database.GetPendingMigrations().Count()==0)
            {
                if(context.Categories.Count()==0)
                {
                    context.Categories.AddRange(Categories);
                }
                if(context.Products.Count()==0)
                {
                    context.Products.AddRange(Products);
                }
                context.SaveChanges();
            }
        }
        private static Category[] Categories = {
            new Category() { Name = "Telefon"},
            new Category() { Name = "Bilgisayar"}
        };
        private static Product[] Products = {
            new Product() { Name = "Samsung s5",Price=1000,ImageUrl="1.jpg"},
           new Product() { Name = "Samsung s6",Price=2000,ImageUrl="2.jpg"},
           new Product() { Name = "Samsung s7",Price=3000,ImageUrl="3.jpg"},
           new Product() { Name = "Samsung s8",Price=4000,ImageUrl="4.jpg"},
           new Product() { Name = "Samsung s9",Price=5000,ImageUrl="5.jpg"},
           new Product() { Name = "iphone 10",Price=11000,ImageUrl="6.jpg"},
           new Product() { Name = "İphone 11",Price=13000,ImageUrl="7.jpg"}
        };

    }
}
