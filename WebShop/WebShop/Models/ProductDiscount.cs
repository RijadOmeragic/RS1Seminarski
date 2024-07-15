using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop.Models
{
    public class ProductDiscount
    {
        [Key]
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public Product? Product { get; set; }

        [ForeignKey(nameof(Discount))]
        public int DiscountId { get; set; }
        public Discount? Discount { get; set; }
    }
}
