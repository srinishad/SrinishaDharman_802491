using Mod.PaymentService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod.PaymentService.Repository
{
   public interface IPaymentRepository
    {
        void Add(Payment item);
        List<Payment> GetAll();
        Payment GetById(int id);
        void Update(Payment item);
        void Delete(int id);
    }
}
