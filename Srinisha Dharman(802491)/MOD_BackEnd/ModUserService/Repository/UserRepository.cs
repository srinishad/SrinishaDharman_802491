using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mod.UserService.Context;
using Mod.UserService.Models;

namespace Mod.UserService.Repository
{
    public class UserRepository : IUserRepository

    {
        private readonly UserContext _context;
        public UserRepository(UserContext context)
        {
            _context = context;
        }
        public void Add(User item)
        {
            try
            {
                _context.User.Add(item);
                _context.SaveChanges();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void Block(int id)
        {
            try
            {
                var item = _context.User.Find(id);
                item.UserActive = !(item.UserActive);
                _context.Entry(item).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<Mentor> SearchMentor(string MentorSkills)
        {
            //return _context.Mentors.Find(MentorSkills);
            try
            {
                return _context.Mentor.Where(i => i.MentorSkills == MentorSkills).ToList();
            }
            catch(Exception)
            {
                throw;
            }

        }

        public void Delete(int id)
        {
            try
            {
                var item = _context.User.Find(id);
                _context.User.Remove(item);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<User> GetAll()
        {
            try
            {
                return _context.User.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public User GetById(int id)
        {
            try
            {
                return _context.User.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(string UserEmail,string UserPassword)
        {
            try
            {
                var item = _context.User.SingleOrDefault(i => i.UserEmail == UserEmail);
                item.UserPassword = UserPassword;
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
