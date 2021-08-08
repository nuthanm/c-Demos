using System;

namespace LinqDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqQueries lq = new LinqQueries
            {
                UseQuerySyntax = true,
            };

            // var products = lq.GetAllColumns();
            // foreach (var item in products)
            // {
            //     Console.WriteLine($"Id: {item.Id} and Name:{item.Name}");
            // }

            // var singleColumnProduct = lq.GetSingleColumn();
            // foreach (var item in singleColumnProduct)
            // {
            //     Console.WriteLine($"Name:{item}");
            // }

            // lq.GetSpeficColumns();

            //  foreach (var item in lq.Products)
            // {
            //     Console.WriteLine($"{item}"); // LinqDemos.Entity.Product
            // }

            // lq.AnonymousClass();

            var products = lq.OrderByDescending();
              foreach (var item in products)
            {
                Console.WriteLine($"{item.Name}"); // LinqDemos.Entity.Product
            }


        }
    }
}
