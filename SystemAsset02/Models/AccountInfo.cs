using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SystemAsset02.Models
{
    public class AccountInfo: IdentityUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_UserI { get; set; }
        public string NameI { get; set; }
        public string UserNameI { get; set; }

        public string PassWordI { get; set; }
        

    }
}
