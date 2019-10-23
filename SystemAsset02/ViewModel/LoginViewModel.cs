using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SystemAsset02.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string PassWordI { get; set; }

        [Display(Name = "Remember")]

        public bool Remember { get; set; }
    }
}
