using LinqDemos.Entity;
using LinqDemos.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemos
{
    public class LinqQueries
    {
        #region Properties
        public List<Product> Products { get; set; }
        public bool UseQuerySyntax { get; set; }
        #endregion Properties
        public LinqQueries()
        {
            Products = ProductRepository.GetAll();
        }

        public List<Product> GetAllColumns()
        {
            /*
            Issue 1:
            Cannot implicitly convert type 'System.Collections.Generic.IEnumerable<LinqDemos.Entity.Product>' to 'System.Collections.Generic.List<LinqDemos.Entity.Product>'. An explicit conversion exists (are you missing a cast?) [LinqDemos]csharp(CS0266)
            Solution:
            Change from ProductRepository.GetAll().Select(prod => prod) to ProductRepository.GetAll().Select(prod => prod).ToList()

            */

            if (UseQuerySyntax)
            {
                return (from product in Products
                        select product).ToList();
            }
            else
            {
                return Products.Select(prod => prod).ToList();
            }
        }

        public List<string> GetSingleColumn()
        {
            if (UseQuerySyntax)
            {
                return (from product in Products select product.Name).ToList();
            }
            else
            {
                return Products.Select(prod => prod.Name).ToList();
            }
        }

        public void GetSpeficColumns()
        {
            if (UseQuerySyntax)
            {
                Products = (from prod in Products
                            select new Product
                            {
                                Id = prod.Id,
                                Name = prod.Name,
                                Color = prod.Color
                            }).ToList();
            }
            else
            {
                Products = Products.Select(
                    prod => new Product
                    {
                        Id = prod.Id,
                        Name = prod.Name,
                        Color = prod.Color
                    }).ToList();

            }
        }

        public void AnonymousClass()
        {

            if (UseQuerySyntax)
            {
                var anonymousProdcuts = (from prod in Products
                                         select new
                                         {
                                             Id = prod.Id,
                                             Name = prod.Name,
                                             Color = prod.Color
                                         }).ToList();

                foreach (var prod in anonymousProdcuts)
                {
                    Console.WriteLine($"Name:{prod.Name}");
                }
            }
            else
            {
                var anonymousProdcuts = Products.Select(
                    prod => new
                    {
                        Id = prod.Id,
                        Name = prod.Name,
                        Color = prod.Color
                    }).ToList();

                foreach (var prod in anonymousProdcuts)
                {
                    Console.WriteLine($"Name:{prod.Name}");
                }
            }
        }

        public List<Product> OrderBy()
        {
            if (UseQuerySyntax)
            {
                return (from product in Products orderby product.Name select product).ToList();
            }
            else
            {
                /*
                Issue: Unhandled exception. System.InvalidOperationException: Failed to compare two elements in the array.
                Solution: Change from Products.OrderBy(prod => prod).ToList(); to Products.OrderBy(prod => prod.Name).ToList();
                */
                return Products.OrderBy(prod => prod.Name).ToList();
                /*
                Note: .Select() method is optional when you are simply selecting an entire object as return value.
                */
            }
        }

        public List<Product> OrderByDescending()
        {
            if (UseQuerySyntax)
            {
                return (from product in Products orderby product.Name descending select product).ToList();
            }
            else
            {
                return Products.OrderByDescending(prod => prod.Name).ToList();
            }
        }

        public List<Product> OrderByTwoFields()
        {
            if (UseQuerySyntax)
            {
                return (from product in Products orderby product.Color descending, product.Name select product).ToList();
            }
            else
            {
                return Products.OrderByDescending(prod => prod.Color).ThenBy(prod => prod.Name).ToList();
            }
        }
    }
}