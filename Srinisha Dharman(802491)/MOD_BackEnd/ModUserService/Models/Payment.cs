using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mod.UserService.Models
{
    [Table("Payment")]
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }

        public float Amount { get; set; }
        [ForeignKey("Mentor")]
        public int MentorId { get; set; }

        public string MentorAmount { get; set; }
        
        
        public User User { get; set; }
        public Mentor Mentor { get; set; }
     
    }
}
