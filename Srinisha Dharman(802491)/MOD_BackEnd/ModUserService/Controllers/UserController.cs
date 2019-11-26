using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mod.UserService.Models;
using Mod.UserService.Repository;

namespace Mod.UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;
        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }
        // GET: api/User
        [HttpGet]
        [Route("GetUsers")]
        public List<User> Get()
        {
             return _repository.GetAll();
        }

        // GET: api/User/5
        //[HttpGet("{id}", Name = "Get")]
        [Route("GetUserById/{id}")]
        public User Get(int id)
        {
            return _repository.GetById(id);
        }

        // POST: api/User
        [HttpPost]
        [Route("Add")]
        public IActionResult Post([FromBody] User item)
        {
            _repository.Add(item);
            return Ok("Record Added");
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        [Route("Update/{UserEmail}/{UserPassword}")]
        public void Put(string UserEmail,string UserPassword)
        {
            _repository.Update(UserEmail,UserPassword);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [Route("Delete/{id}")]
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
        [Route("GetMentorBySkill/{id}")]
        public List<Mentor> Get(string id)
        {
            return _repository.SearchMentor(id);
        }
        [HttpPut("{id}")]
        [Route("BlockUser/{id}")]
        public void put(int Id)
        {
            _repository.Block(Id);
        }
    }
}
