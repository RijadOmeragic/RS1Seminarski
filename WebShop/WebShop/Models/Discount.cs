namespace WebShop.Models
{
    public class Discount
    {
        public int DiscountId { get; set; }
        public string? Name { get; set; }
        public double Amount { get; set; }
        public string? Description  { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }

    }
}
