using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebShop.Enums;

namespace WebShop.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public double TotalAmount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public double Tax { get; set; }
        public string? Address { get; set; }

        [ForeignKey(nameof(Membership))]
        public int MembershipId { get; set; }
        public Membership? Membership { get; set; }

        [ForeignKey(nameof(OrderStatus))]
        public int OrderStatusId { get; set; }
        public OrderStatus? OrderStatus { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
