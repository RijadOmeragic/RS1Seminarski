using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop.Models
{
    public class WishList
    {
        [Key]
        public int WishListId { get; set; }
        public string? Name{ get; set; }

        public ICollection<WishListProduct>? WishListProducts { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User? User { get; set; }

    }
}
