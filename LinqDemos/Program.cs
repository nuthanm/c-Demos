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

            // var products = lq.OrderByDescending();
            //   foreach (var item in products)
            // {
            //     Console.WriteLine($"{item.Name}"); // LinqDemos.Entity.Product
            // }

            // var products = lq.OrderByTwoFields();
            //   foreach (var item in products)
            // {
            //     Console.WriteLine($"{item.Name}"); // LinqDemos.Entity.Product
            // }

            //  var products = lq.WhereExpression();
            //   foreach (var item in products)
            // {
            //     Console.WriteLine($"{item.Name}"); // LinqDemos.Entity.Product
            // }

            // var products = lq.WhereWithMultipleExpressions();
            //   foreach (var item in products)
            // {
            //     Console.WriteLine($"{item.Name}"); // LinqDemos.Entity.Product
            // }

            // var products = lq.UseCustomExtensionMethod();
            //   foreach (var item in products)
            // {
            //     Console.WriteLine($"{item.Name}");
            // }


            // var product = lq.FirstWithOutAnyWhere();
            // Console.WriteLine($"{product.Name}");


            //    var product = lq.FirstWithyWhereNotExists();
            //    Console.WriteLine($"{product.Name}");
            // Note: Unhandled exception. System.InvalidOperationException: Sequence contains no matching element
            // To fix this unhandled exception use FirstOrDefault or use try and catch

            // var product = lq.FirstOrDefaultWithyWhereNotExists();

            // if(product == null)
            // {
            //     Console.WriteLine("Product is not found");
            //     return;
            // }

            // Console.WriteLine($"{product.Name}");

            //Note: Unhandled exception. System.NullReferenceException: Object reference not set to an instance of an object.
            // To fix this change from product.Name to product?.Name or check product == null

            // var product = lq.FirstWithyWhereExists();
            // Console.WriteLine($"{product.Name}");

            //      var product = lq.LastWithOutAnyWhere();
            //    Console.WriteLine($"{product.Name}");
            //    // Note: Last method from backward


            // var product = lq.LastWithyWhereNotExists();
            // Console.WriteLine($"{product.Name}");


            // var product = lq.LastWithyWhereExists();
            // Console.WriteLine($"{product.Name}");


            // var product = lq.LastOrDefaultWithyWhereNotExists();
            // Console.WriteLine($"{product?.Name}");


            // var product = lq.SingleWithOutAnyWhere();
            // Console.WriteLine($"{product?.Name}");
            //Note: Unhandled exception. System.InvalidOperationException: Sequence contains more than one element
            // Because we have Orange values are two


            // var product = lq.SingleOrDefaultWithWhereNotExists();
            // Console.WriteLine($"{product?.Name}");

            // var product = lq.SingleWithWhereExists();
            // Console.WriteLine($"{product?.Name}");

            
            var product = lq.SingleWithyWhereNotExists();
            Console.WriteLine($"{product?.Name}");

        }
    }
}
