using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge34Library.Models
{
    public class Basket
    {
        
        [Key]
        public int UserId { get; set; }
        public int BasketAmount { get; set; }
        public double TotalPrice { get; set; }

        public List<Product> products { get; set; }
        public User User { get; set; }
    }
}
