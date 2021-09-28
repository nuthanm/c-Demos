namespace EfCoreDemo.Models
{
    public class ProductOrder
    {
        public int Id { get; set; }

        public int  Quantity { get; set; }

        public int ProductId { get; set; }

        public int OrderId { get; set; }

        public Product Products { get; set; }

        public Order Orders { get; set; }

    }
}
