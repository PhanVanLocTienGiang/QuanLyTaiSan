using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssetSystem01.ViewModel
{
    public class LoginViewModel
    {
        [Required]    
        public string UserName2 { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Display(Name = "Remember")]

        public bool Remember { get; set; }
    }
}
