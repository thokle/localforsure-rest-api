using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using data_soruce_mil.models;
using localforsure_rest_api.factory;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace localforsurerestapi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpGet("{username}/{password}")]
        public User GetUserByCredentials(string useranme, string password) {
            return Factory.GetUserService().GetUserByCredentials(useranme, password);
        }
            
    }
}
