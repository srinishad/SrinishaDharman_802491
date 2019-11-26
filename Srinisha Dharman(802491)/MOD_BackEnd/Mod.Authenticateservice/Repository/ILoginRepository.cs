using Mod.Authenticateservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod.Authenticateservice.Repository
{
   public interface ILoginRepository
    {
        User UserLogin(string UserEmail,string UserPassword);
        Mentor MentorLogin(string MentorEmail,string MentorPassword);
    }
}
