using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop.Models
{
    public class StockItem
    {
        [Key]
        public int StockItemId { get; set; }
        public bool IsInStock { get; set; }
        public int Quantity { get; set; }
        public DateTime? LastUpdated { get; set; }   // da li treba biti nullable 
        public string? Size { get; set; }

        [ForeignKey(nameof(Storage))]
        public int StorageId { get; set; }
        public Storage? Storage { get; set; }

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
