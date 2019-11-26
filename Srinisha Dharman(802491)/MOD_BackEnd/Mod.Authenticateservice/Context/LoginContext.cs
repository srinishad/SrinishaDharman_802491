using Microsoft.EntityFrameworkCore;
using Mod.Authenticateservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod.Authenticateservice.Context
{
    public class LoginContext:DbContext
    {
        public LoginContext(DbContextOptions<LoginContext> options) : base(options)
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Mentor> Mentor { get; set; }
    }
}
