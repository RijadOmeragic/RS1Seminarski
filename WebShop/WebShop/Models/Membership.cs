using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop.Models
{
    public class Membership
    {
        [Key]
        public int MembershipId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User? User  { get; set; }

    }
}
