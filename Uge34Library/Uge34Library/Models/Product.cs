﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge34Library.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }

        public Basket Basket { get; set; }
    }
}
