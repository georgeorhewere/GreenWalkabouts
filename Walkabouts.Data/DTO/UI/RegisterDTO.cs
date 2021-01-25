using System.ComponentModel.DataAnnotations;

namespace Walkabouts.Data.DTO
{
    public class RegisterDTO
    {
        public long Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
    }
}