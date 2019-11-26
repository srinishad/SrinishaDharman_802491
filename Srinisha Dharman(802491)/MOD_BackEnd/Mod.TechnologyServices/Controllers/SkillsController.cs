using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mod.TechnologyServices.Models;
using Mod.TechnologyServices.Repository;

namespace Mod.TechnologyServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        private readonly ISkillsRepository _repository;
        public SkillsController(ISkillsRepository repository)
        {
            _repository = repository;
        }
        // GET: api/Skills
        [HttpGet]
        [Route("GetSkills")]
        public List<Skills> Get()
        {
            return _repository.GetAll();
        }

        // GET: api/Skills/5
        //[HttpGet("{id}", Name = "Get")]
        [Route("GetSkillsById/{id}")]
        public Skills Get(int id)
        {
            return _repository.GetById(id);
        }

        // POST: api/Skills
        [HttpPost]
        [Route("AddSkills")]
        public IActionResult Post(Skills item)
        {
            _repository.Add(item);
            return Ok();
        }

        // PUT: api/Skills/5
        [HttpPut("{id}")]
        [Route("UpdateSkills/{id}")]
        public IActionResult Put(Skills item)
        {
            _repository.Update(item);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [Route("DeleteSkills/{id}")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return Ok();
        }
    }
}
