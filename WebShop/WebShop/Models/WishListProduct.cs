using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebShop.Models
{
    public class WishListProduct
    {
        [ForeignKey(nameof(WishList))]
        public int WishListId { get; set; }
        public WishList? WishList { get; set; }

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
