using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge34Library.Repo
{
    public interface IRepository<T> where T:class
    {
        void CreateProduct(T obj);

        List<T> GetAll();
        
        void Update(T obj);

        void DeleteProduct(int id);

        T GetByid(int id);

    }
}
