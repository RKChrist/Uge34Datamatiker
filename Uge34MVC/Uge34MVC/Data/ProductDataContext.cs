using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Uge34Library.Models;

    public class ProductDataContext : DbContext
    {
        public ProductDataContext (DbContextOptions<ProductDataContext> options)
            : base(options)
        {
        }

        public DbSet<Uge34Library.Models.Product> Product { get; set; }
        public DbSet<Basket> Basket { get; set; }
        public DbSet<User> User { get; set; }

}
