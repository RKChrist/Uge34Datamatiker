using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge34Library.Models
{
    public class User : IdentityUser
    {

        public string Name { get; set; }
        public string PassWord { get; set; }
        public string Mail { get; set; }
        public bool IsAdmin { get; set; }
        public string Address { get; set; }




        //public int Phonenumber { get; set; }

        public List<Basket> Basket { get; set; }
    }

}
