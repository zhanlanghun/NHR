using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using NHR.IRepository;
namespace NHR.Service
{
    public class UserService
    {
        public IUserRepository user { get; set; }
        public UserService(IUserRepository _user)
        {
            this.user = _user;
        }
        public void Add()
        {
            //IUserRepository r = new UserRepository();
            user.Add(new Entity.User() { UserName = "rrewrewrew" });
        }
    }
}
