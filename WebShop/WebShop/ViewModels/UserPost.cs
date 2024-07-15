using WebShop.Enums;

namespace WebShop.ViewModels
{
    public class UserPost
    {
        public UserRole Role { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Gender { get; set; }
        public bool IsActive { get; set; }
    }
}
