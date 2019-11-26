using Mod.Authenticateservice.Context;
using Mod.Authenticateservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod.Authenticateservice.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly LoginContext _context;
        public LoginRepository(LoginContext context)
        {
            _context = context;
        }
        public Mentor MentorLogin(string MentorEmail, string MentorPassword)
        {
            try
            {
                return _context.Mentor.SingleOrDefault(data => data.MentorEmail == MentorEmail && data.MentorPassword == MentorPassword);
            }
            catch (Exception)
            {
                throw;
            }
            //if (obj != null)
            //    return true;
            //else
            //    return false;
        }

        public User UserLogin(string UserEmail, string UserPassword)
        {
            try
            {
                return _context.User.SingleOrDefault(data => data.UserEmail == UserEmail && data.UserPassword == UserPassword);
            }
            catch (Exception)
            {
                throw;
            }
            //if (obj != null)
            //    return true;
            //else
            //    return false;
        }
    }
}
