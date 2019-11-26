using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mod.TrainingService.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
       
        
        public string UserName { get; set; }
       
        public string UserEmail { get; set; }
       
        public long UserNumber { get; set; }
       
        public string UserPassword { get; set; }
       
        public bool UserActive { get; set; }
        public IEnumerable<Training> Training { get; set; }
        public IEnumerable<Payment> Payment { get; set; }
    }
}
