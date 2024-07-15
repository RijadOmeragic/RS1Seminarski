using Microsoft.AspNetCore.Mvc;
using WebShop.Data;
using WebShop.Models;
using WebShop.ViewModels;

namespace WebShop.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]

    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public UserController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        [HttpGet]
       public ActionResult GetALL()
       {
            var users = _applicationDbContext.Users.ToList();

            return Ok(users);

       }

        [HttpPost]
        public ActionResult Post([FromBody] UserPost user)
        {
            var newUser = new User
            {
                Role = user.Role,
                Email = user.Email,
                Password = user.Password,
                FirstName = user.FirstName,  
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                Address = user.Address,  
                City = user.City,    
                PostalCode = user.PostalCode,
                RegistrationDate = user.RegistrationDate,
                BirthDate = user.BirthDate, 
                Gender = user.Gender,
                IsActive = user.IsActive, 
            };

            _applicationDbContext.Users.Add(newUser);
            _applicationDbContext.SaveChanges();

            return Ok(user);
        }
    }
}
