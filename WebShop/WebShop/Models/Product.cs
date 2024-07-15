using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebShop.Enums;

namespace WebShop.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public byte[]? Image { get; set; }
        public bool IsOneSize { get; set; }
        public List<string>? Sizes { get; set; }
        public GenderType Gender { get; set; }
        public bool IsLongSleeve { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        public ICollection<WishListProduct>? WishListProducts { get; set; }


    }
}
