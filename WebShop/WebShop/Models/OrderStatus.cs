using System.ComponentModel.DataAnnotations;

namespace WebShop.Models
{
    public class OrderStatus
    {
        [Key]
        public int OrderStatusId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }


    }
}
