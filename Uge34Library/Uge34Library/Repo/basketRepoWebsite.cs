using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Uge34Library.Models;

namespace Uge34Library.Repo
{
    public class basketRepoWebsite : IRepository<Basket>
    {
        private IdentityDbContext _context;
        private DbSet<Basket> table;

        public basketRepoWebsite(IdentityDbContext context)
{
            _context = context;
            table = _context.Set<Basket>();
        }

        public void CreateProduct(Basket obj)
        {
            table.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteProduct(Basket obj)
        {
            throw new NotImplementedException();
        }

        public List<Basket> GetAll()
        {
            return table.ToList();
        }

        public Basket GetByid(int id)
        {
            return table.Find(id);
        }

        public void Update(Basket obj)
        {
            table.Update(obj);
            _context.SaveChanges();
        }
    }
}