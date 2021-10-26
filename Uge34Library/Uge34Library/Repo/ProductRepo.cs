using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uge34Library.Data;
using Uge34Library.Models;

namespace Uge34Library.Repo
{
    public class ProductRepo : IRepository<Product>
    {

        private ApplicationDbContext _context;
        private DbSet<Product> table;

        public ProductRepo(ApplicationDbContext _context)
        {
            this._context = _context;
            table = _context.Set<Product>();
        }
        public void CreateProduct(Product obj)
        {
            table.Add(obj);
        }

        public void DeleteProduct(Product obj)
        {
            table.Remove(obj);
        }

        public List<Product> GetAll()
        {
            return table.ToList();
        }

        public Product GetByid(int id)
        {
            return table.Find(id);
        }

        public void Update(Product obj)
        {
            table.Attach(obj);
            table.Update(obj);
        }
    }
}
