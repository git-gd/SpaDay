using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.ViewModel
{
    public class AddUserViewModel
    {
        [Required]
        [StringLength(15, MinimumLength = 5, ErrorMessage ="Username must be between 5 and 15 characters.")]
        public string Username { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 6, ErrorMessage ="Password must be between 6 and 20 characters.")]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage ="Passwords do not match!")]
        public string VerifyPassword { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}