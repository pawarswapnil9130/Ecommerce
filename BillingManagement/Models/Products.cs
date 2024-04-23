using System.ComponentModel.DataAnnotations;

namespace Ekart.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }
        public int CategoryId { get; set; }

        public string imageUrl { get; set; }

        public int Discount { get; set; }

        public int Warrenty { get; set; }

    }
}
