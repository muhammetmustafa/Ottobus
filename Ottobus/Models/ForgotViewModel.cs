using System.ComponentModel.DataAnnotations;

namespace Ottobus.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}