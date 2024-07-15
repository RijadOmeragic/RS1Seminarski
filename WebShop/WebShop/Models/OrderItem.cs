using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public int  Quantity { get; set; }
        public double Price { get; set; }
        public double DoublePrice { get; set; }
        public double PriceTotal { get; set;}

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public Product? Product { get; set; }

        [ForeignKey(nameof(Order))]
        public int OrderId { get; set; }
        public Order? Order { get; set; }

        [ForeignKey(nameof(ReturnRequest))] 
        public int ReturnRequestId { get; set; }
        public ReturnRequest? ReturnRequest { get; set; }



    }
}
