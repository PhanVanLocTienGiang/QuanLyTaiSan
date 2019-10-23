using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssetSystem01.ViewModel
{
    public class CreateRolesViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
