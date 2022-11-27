using DataAccess.Abstract;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class Repository <T> : IRepository<T> where T : class

    {
        Acontext c = new Acontext();
        DbSet<T> obj;

        public Repository()
        {
            obj = c.Set<T>();
        }

        public int add(T entity)
        {
            obj.Add(entity);
            return c.SaveChanges();
        }

        public int delete(T entity)
        {
            obj.Remove(entity);
            return c.SaveChanges();
        }

        public List<T> GetAll(System.Linq.Expressions.Expression<Func<T, bool>> filter = null)
        {
          return obj.ToList();
             
        }

     

        public T GetById(int id)
        {
            return obj.Find(id);
        }

        public int update(T entity)
        {
            obj.Update(entity);
           return c.SaveChanges();
        }
    }
}
