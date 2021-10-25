using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge34Library.Models
{
    public class Basket
    {
        public int UserId { get; set; }
        public int BasketAmount { get; set; }
        public double TotalPrice { get; set; }

        public List<Product> products { get; set; }
    }
}
