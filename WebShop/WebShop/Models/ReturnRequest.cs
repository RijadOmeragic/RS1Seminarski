using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebShop.Enums;

namespace WebShop.Models
{
    public class ReturnRequest
    {
        [Key]
        public int ReturnRequestId { get; set; }
        public string? Reason { get; set; }
        public ReturnRequestStatus Status { get; set; }
        public DateTime RequestedAt { get; set; }
        public string? Comment { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User? User { get; set; }

    }
}
