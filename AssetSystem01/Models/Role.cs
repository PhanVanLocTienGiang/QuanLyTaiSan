using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AssetSystem01.Models
{
    public class Role: IdentityRole
    {
        public Role() : base() { }

        public Role(string name) : base(name) { }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Role { get; set; }
       public string Name2 { get; set; }
        
    }
}
