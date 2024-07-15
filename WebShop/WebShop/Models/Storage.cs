using System.ComponentModel.DataAnnotations;

namespace WebShop.Models
{
    public class Storage
    {
        [Key]
        public int StorageId { get; set; }
        public string? LocationName { get; set; }
        public string? Address { get; set; }


    }
}
