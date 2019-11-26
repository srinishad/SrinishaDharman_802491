using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mod.UserService.Context;
using Mod.UserService.Models;

namespace Mod.UserService.Repository
{
    public class MentorRepository : IMentorRepository
    {

        private readonly UserContext _context;
        public MentorRepository(UserContext context)
        {
            _context = context;
        }
        public void Add(Mentor item)
        {
            try
            {

                _context.Mentor.Add(item);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Block(int id)
        {
            try
            {
                var item = _context.Mentor.Find(id);
                item.MentorActive = !(item.MentorActive);
                _context.Entry(item).State = EntityState.Modified;
                _context.SaveChanges();
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
                var item = _context.Mentor.Find(id);
                _context.Mentor.Remove(item);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Mentor> GetAll()
        {
            try
            {
                return _context.Mentor.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Mentor GetById(int id)
        {
            try
            {
                return _context.Mentor.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
        }



        public void Update(string MentorEmail, string MentorPassword)
        {
            try
            {
                var item = _context.Mentor.SingleOrDefault(i => i.MentorEmail == MentorEmail);
                item.MentorPassword = MentorPassword;
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
