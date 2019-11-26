using Mod.TechnologyServices.Context;
using Mod.TechnologyServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod.TechnologyServices.Repository
{
    public class SkillsRepository:ISkillsRepository
    {
        private readonly SkillsContext _context;
        public SkillsRepository(SkillsContext context)
        {
            _context = context;
        }

        public void Add(Skills item)
        {
            try
            {
                _context.Skills.Add(item);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Skills> GetAll()
        {
            try
            {
                return _context.Skills.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Skills GetById(int id)
        {
            try
            {
                return _context.Skills.Find(id);
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
                var item = _context.Skills.Find(id);
                _context.Skills.Remove(item);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Update(Skills item)
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
    }
}
