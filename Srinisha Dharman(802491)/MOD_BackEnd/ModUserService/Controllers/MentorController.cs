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
    public class MentorController : ControllerBase
    {
        private readonly IMentorRepository _repository;
        public MentorController(IMentorRepository repository)
        {
            _repository = repository;
        }
        // GET: api/Mentor
        [HttpGet]
        [Route("GetMentors")]
        public List<Mentor> Get()
        {
            return _repository.GetAll();
        }

        // GET: api/Mentor/5
        //[HttpGet("{id}", Name = "Get")]
        [Route("GetMentorById/{id}")]
        public Mentor Get(int id)
        {
            return _repository.GetById(id);
        }

        // POST: api/Mentor
        [HttpPost]
        [Route("AddMentor")]
        public IActionResult Post([FromBody]  Mentor item)
        {
            _repository.Add(item);
            return Ok("Record Added");
        }

        // PUT: api/Mentor/5
        [HttpPut("{id}")]
        [Route("UpdateMentor/{MentorEmail}/{MentorPassword}")]
        public void Put(string MentorEmail, string MentorPassword)
        {
            _repository.Update(MentorEmail, MentorPassword);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [Route("Delete/{id}")]
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
        [HttpPut("{id}")]
        [Route("BlockMentor/{id}")]
        public void put(int Id)
        {
            _repository.Block(Id);
        }
    }
}
