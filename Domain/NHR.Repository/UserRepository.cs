using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NHR.Entity;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using NHR.IRepository;
namespace NHR.Repository
{
    public class UserRepository:BaseRepository<User>,IUserRepository
    {
        //public void Add()
        //{
        //    NHRContext context = new Repository.NHRContext();
        //    EntityEntry<User>  user= context.Users.Add(new User() { UserName = "testname" });
        //    context.SaveChanges();
        //}
    }
}
