using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop.Models
{
    public class OrderHistory
    {
        [Key]
        public int OrderHistoryId { get; set; }
        public DateTime TimeStamp { get; set; }
        public string? Action { get; set; }
        public string? Comment { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User? User { get; set; }

        [ForeignKey(nameof(Order))]
        public int OrderId { get; set; }
        public Order? Order { get; set; }

        [ForeignKey(nameof(OrderStatus))]
        public int OrderStatusId { get; set; }
        public OrderStatus? OrderStatus { get; set; }

    }
}
