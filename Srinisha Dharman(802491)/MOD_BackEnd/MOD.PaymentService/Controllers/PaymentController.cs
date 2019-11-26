using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mod.PaymentService.Models;
using Mod.PaymentService.Repository;

namespace Mod.PaymentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentRepository _repository;
        public PaymentController(IPaymentRepository repository)
        {
            _repository = repository;
        }
        // GET: api/Payment
        [HttpGet]
        [Route("GetPayment")]
        public List<Payment> Get()
        {
            return _repository.GetAll();
        }

        // GET: api/Payment/5
       // [HttpGet("{id}", Name = "Get")]
        [Route("GetPaymentById/{id}")]
        public Payment Get(int id)
        {
            return _repository.GetById(id);
        }

        // POST: api/Payment
        [HttpPost]
        [Route("AddPayment")]
        public IActionResult Post([FromBody] Payment item)
        {
            _repository.Add(item);
            return Ok("Record Added");
        }

        // PUT: api/Payment/5
        [HttpPut("{id}")]
        [Route("UpdatePayment/{id}")]
        public void Put([FromBody]Payment item)
        {
            _repository.Update(item);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [Route("DeletePayment/{id}")]
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
