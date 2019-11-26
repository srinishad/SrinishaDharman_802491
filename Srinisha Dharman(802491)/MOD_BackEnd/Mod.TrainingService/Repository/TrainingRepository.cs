using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mod.TrainingService.Context;
using Mod.TrainingService.Models;

namespace Mod.TrainingService.Repository
{
    public class TrainingRepository : ITrainingRepository
    {
        private readonly TrainingContext _context;
        public TrainingRepository(TrainingContext context)
        {
            _context = context;
        }
        public void Add(Training item)
        {
            try
            {
                _context.Training.Add(item);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Training item)
        {
            try
            {
                _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }

        }
        public List<Training> GetAll()
        {
            try
            {
                return _context.Training.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Training GetById(int id)
        {
            try
            {
                return _context.Training.Find(id);
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
                var item = _context.Training.Find(id);
                _context.Training.Remove(item);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Training> GetTrainingByUserId(int id)
        {
            try
            {
                return _context.Training.Where(i => i.UserId == id).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Training> GetTrainingByMentorId(int id)
        {
            try
            {
                return _context.Training.Where(i => i.MentorId == id).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
