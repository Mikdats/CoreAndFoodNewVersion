using CoreAndFood.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CoreAndFood.Repositories
{
    public class GenericRepository<T> where T : class,new()
    {
        Context c = new Context();

        public List<T> TList()
        {
            return c.Set<T>().ToList();
        }
        public void TAdd(T t)
        {
            c.Set<T>().Add(t);
            c.SaveChanges();
        }
        public void TDelete(T t)
        {
            c.Set<T>().Remove(t);
            c.SaveChanges();
        }
        public void TUpdate(T t)
        {
            c.Set<T>().Update(t);
            c.SaveChanges();
        }
        public T TGet(int id)
        {
             return c.Set<T>().Find(id);
           
        }   
        public List<T> List(Expression<Func<T,bool>>filter)
		{
            return c.Set<T>().Where(filter).ToList();
		}
    }
}
