using System.ComponentModel.DataAnnotations;
namespace PartyInvites.Models
{
    public class GuestResponse 
    {
        [Required(ErrorMessage = "Name is Required")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Phone is Required")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public bool? WillAttend { get; set; }
    }
}