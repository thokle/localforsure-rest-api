using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using localforsure_rest_api.daos;
using localforsure_rest_api.models;
using localforsure_rest_api.services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace localforsure_rest_api.Controllers
    
{
[Route("api/[controller]")]
public class UserController : Controller
{
    private UserService _dao;

    public UserController()
    {
        _dao = new UserService();
    }

    // GET: api/<controller>
    [HttpGet]
    public IEnumerable<User> Get()
    {
        return _dao.GetAllUsers();

    }

    // GET api/<controller>/5
    [HttpGet("{id}")]
    public User Get(int id)
    {
        return new User() {};
    }

    // POST api/<controller>
    [HttpPost]
    public void Post([FromBody]string value)
    {
        //_dao.CreateUser(new User()
       
    }

    // PUT api/<controller>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/<controller>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
}
