using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NHR.Service;
using NHR.IRepository;
namespace NHR.Api.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        public IUserRepository user { get; set; }
        public UserService userService { get; set; }
        public ValuesController(IUserRepository _user,UserService _userService)
        {
            this.user = _user;
            this.userService = _userService;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
           // user.Add(new Entity.User() { UserName = "rrewrewrew" });
            userService.Add();
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
