using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge34Library.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string PassWord { get; set; }
        public string Mail { get; set; }
        public bool IsAdmin { get; set; }
        public string Address { get; set; }
        public int Phonenumber { get; set; }
    }

}
