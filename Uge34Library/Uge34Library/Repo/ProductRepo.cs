using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uge34Library.Models;

namespace Uge34Library.Repo
{
    public class ProductRepo : IRepository<Product>
    {

        private DbContext _context;
        private DbSet<Product> table;

        public ProductRepo(DbContext _context)
        {
            this._context = _context;
            table = _context.Set<Product>();
        }

        public void CreateProduct(Product obj)
        {
            table.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteProduct(Product obj)
        {
            table.Remove(obj);
            _context.SaveChanges();
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
            table.Update(obj);
            _context.SaveChanges();
        }
    }
}
