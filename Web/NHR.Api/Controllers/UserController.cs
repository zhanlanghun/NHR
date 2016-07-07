using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NHR.DTO;
using NHR.Service;
using NHR.IRepository;
// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NHR.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    public class UserController : BaseController
    {
      // [HttpGet("index")]
        public JsonResult Index(UserDTO user)
        {
            Response.StatusCode = 200;
            return Json(new UserDTO());
        }
        /// <summary>
        /// 用户的注册
        /// </summary>
        /// <returns></returns>
        [HttpGet]
       public object Login(UserDTO user)
        {
            if (user==null||string.IsNullOrWhiteSpace(user.Account)||string .IsNullOrWhiteSpace(user.PassWord))
            {
                return Json("2222");
            }
            return Json("11111111111");
        }
    }
}
