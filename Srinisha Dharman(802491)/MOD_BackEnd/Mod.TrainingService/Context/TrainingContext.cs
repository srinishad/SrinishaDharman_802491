using Microsoft.EntityFrameworkCore;
using Mod.TrainingService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod.TrainingService.Context
{
    public class TrainingContext:DbContext
    {
        public TrainingContext(DbContextOptions<TrainingContext> options) : base(options)
        {

        }
        public DbSet<Training> Training { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Mentor> Mentor { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Payment> Payment { get; set; }
    }
}
