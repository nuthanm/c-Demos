using System.Collections.Generic;
using System.Linq;
using LinqDemos.Entity;

namespace LinqDemos.Repository
{
    public static class ProductExtension
    {
        public static IEnumerable<Product> ByColor(this IEnumerable<Product> query, string color)
        {
            return query.Where(prod => prod.Color == color);
        }
    }
}