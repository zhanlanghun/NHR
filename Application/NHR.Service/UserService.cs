using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NHR.DTO;
using NHR.IRepository;
using NHR.Entity;
namespace NHR.Service
{
    public class UserService
    {
        public IUserRepository userR { get; set; }
        public UserService(IUserRepository _user)
        {
            this.userR = _user;
        }
        public void Add()
        {
            int i = 0;
            List<Entity.User> lstUser = new List<Entity.User>();
            while (i < 10000)
            {
                var user1 = new Entity.User() { UserName = "rrewrewrew"+i, Account = "testacount"+i, PassWord = "testpwd"+i };
                lstUser.Add(user1);
                i++;
            }
            var user = new Entity.User() { UserName = "rrewrewrew",Account="testacount",PassWord="testpwd" };

            var d= user.MapTo<DTO.UserDTO>();
            var dd = d.MapTo<Entity.User>();

            //List<Entity.User> lst1 = new List<Entity. User>();
            //lst1.Add(user);
            var ls2 = lstUser.MapToList<Entity.User, UserDTO>();
            var ls3 = ls2.MapToList<UserDTO, User>();
            //IUserRepository r = new UserRepository();
            userR.Add(user);
        }
    }
}
