using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NHR.Entity;
namespace NHR.Repository
{
    public class BaseRepository<T>
        where T:EntityBase
    {

       public void Add(T t)
        {
            using(NHRContext context=new NHRContext())
            {
                context.Set<T>().Add(t);
                context.SaveChanges();
            }
        }
     
       public T GetByID(int ID)
        {
            using (NHRContext context = new NHRContext())
            {
                return context.Set<T>().FirstOrDefault(s => s.ID == ID);
            }
        }
    }
}
