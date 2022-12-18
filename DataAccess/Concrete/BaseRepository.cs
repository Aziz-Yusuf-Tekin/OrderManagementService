using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        public void Delete(T t)
        {
            using var c = new ApplicationDbContext();
            c.Remove(t);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            using var c = new ApplicationDbContext();
            return c.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            using var c = new ApplicationDbContext();
            return c.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var c = new ApplicationDbContext();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            using var c = new ApplicationDbContext();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
