using System.Collections.Generic;
using LinqDemos.Entity;

namespace LinqDemos.Repository
{
    public class ProductRepository
    {
        public static List<Product> GetAll()
        {
            return new List<Product> {
                new Product {
                    Id=1,
                    Name ="Himalyas",
                    Color="Green",
                    StandardCost = 100,
                    ListPrice = 20,
                    Size ="2",
                },
                new Product {
                    Id=2,
                    Name ="Santoor",
                    Color="Orange",
                    StandardCost = 140,
                    ListPrice = 25,
                    Size ="20",
                },
                new Product {
                    Id=3,
                    Name ="Old Chintol",
                    Color="Dark Green",
                    StandardCost = 130,
                    ListPrice = 30,
                    Size ="1",
                }
            };
        }
    }
}