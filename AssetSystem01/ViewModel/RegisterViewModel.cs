using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssetSystem01.ViewModel
{
    public class RegisterViewModel
    {
        [Required]       
        public string UserName2 { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } 
    }
}
