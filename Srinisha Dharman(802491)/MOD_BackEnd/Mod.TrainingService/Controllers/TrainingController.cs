using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mod.TrainingService.Models;
using Mod.TrainingService.Repository;

namespace Mod.TrainingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingController : ControllerBase
    {
        private readonly ITrainingRepository _repository;
        public TrainingController(ITrainingRepository repository)
        {
            _repository = repository;
        }
        // GET: api/Training
        [HttpGet]
        [Route("GetTrainings")]

        public List<Training> Get()
        {
            return _repository.GetAll();
        }

        // GET: api/Training/5
        //[HttpGet("{id}", Name = "Get")]
        [Route("GetTrainingById/{id}")]
        public Training Get(int id)
        {
            return _repository.GetById(id);
        }

        // POST: api/Training
        [HttpPost]
        [Route("AddTraining")]
        public IActionResult Post([FromBody] Training item)
        {
            _repository.Add(item);
            return Ok("Record Added");
        }

        // PUT: api/Training/5
        [HttpPut("{id}")]
        [Route("UpdateTraining/{id}")]
        public void Put([FromBody]Training item)
        {
            _repository.Update(item);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [Route("DeleteTraining/{id}")]
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
        [HttpGet("{id}", Name = "GetByUser")]
        [Route("GetTrainingByUserId/{id}")]
        public List<Training> GetByUser(int id)
        {
            return _repository.GetTrainingByUserId(id);
        }
        [HttpGet("{id}", Name = "GetByMentor")]
        [Route("GetTrainingByMentorId/{id}")]
        public List<Training> GetByMentor(int id)
        {
            return _repository.GetTrainingByMentorId(id);
        }
    }
}
