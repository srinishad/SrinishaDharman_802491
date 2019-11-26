using Mod.UserService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod.UserService.Repository
{
   public interface IUserRepository
    {
        void Add(User item);
        List<User> GetAll();
        User GetById(int id);
        void Update(string UserEmail,string UserPassword);
        void Delete(int id);
        void Block(int id);
        List<Mentor> SearchMentor(string MentorSkills);
    }
}
