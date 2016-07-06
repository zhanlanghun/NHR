using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NHR.Entity;
namespace NHR.IRepository
{
    public interface IBaseRepository<T>
        where T:EntityBase
    {
        void Add(T t);
      
        T GetByID(int ID);
    }
}
