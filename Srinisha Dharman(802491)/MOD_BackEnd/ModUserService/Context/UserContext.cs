using Microsoft.EntityFrameworkCore;
using Mod.UserService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod.UserService.Context
{
    public class UserContext:DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server = DESKTOP-V5LG2JJ\SQLEXPRESS;Database=MentorOnDemand;Trusted_Connection=True ");
        //}
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Mentor> Mentor { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Training> Training { get; set; }
        public DbSet<Payment> Payment { get; set; }

    }

}
