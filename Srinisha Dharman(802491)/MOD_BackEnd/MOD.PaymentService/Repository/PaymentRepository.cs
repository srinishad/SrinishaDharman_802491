using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mod.PaymentService.Context;
using Mod.PaymentService.Models;

namespace Mod.PaymentService.Repository
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly PaymentContext _context;
        public PaymentRepository(PaymentContext context)
        {
            _context = context;
        }

        public void Add(Payment item)
        {
            try
            {
                _context.Payment.Add(item);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Payment> GetAll()
        {
            try
            {
                return _context.Payment.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Payment GetById(int id)
        {
            try
            {
                return _context.Payment.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Delete(int id)
        {
            try
            {
                var item = _context.Payment.Find(id);
                _context.Payment.Remove(item);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Update(Payment item)
        {
            try
            {
                _context.Entry(item).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
