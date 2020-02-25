using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using data_soruce_mil.models;
using localforsure_rest_api.factory;
using Newtonsoft.Json;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
using  Newtonsoft.Json.Converters;
namespace localforsurerestapi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpGet("{username}/{password}")]
        public User GetUserByCredentials(string useranme, string password)
        {
            return Factory.GetUserService().GetUserByCredentials(useranme, password);
        }


        [HttpPost]
        public User CreateUser([FromBody]string s)
        {
          var res =   JsonConvert.DeserializeObject<User>(s);
            var user = new User();
            return Factory.GetUserService().CreateOrUpdate(user: res);
        }

        [HttpPut]
        public User UpdateUser(string s)
        {
            User user = new User();
            return Factory.GetUserService().CreateOrUpdate(user);
        }

    }
}
