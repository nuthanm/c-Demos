using EfCoreDemo.Data;
using EfCoreDemo.Models;
using System;

namespace EfCoreDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using EFCoreDemoContext context = new EFCoreDemoContext();

            var product = new Product()
            {
                Name = "Airpods",
                Price = 25000,
            };

            context.Add(product);
            context.SaveChanges();
        }
    }
}
