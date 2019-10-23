using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AssetSystem01.Models
{
    public class User : IdentityUser
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_User2 { set; get; }
        public string Name2 { get; set; }
        public string UserName2 { set; get; }
        public string PassWord2 { set; get; }
        

    }
}
