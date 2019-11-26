using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mod.PaymentService.Models
{
    public class Mentor
    {
        [Key]
        public int MentorId { get; set; }

        public string MentorName { get; set; }
        public string MentorEmail { get; set; }
        public long MentorNumber { get; set; }
        public string MentorPassword { get; set; }
        public string MentorSkills { get; set; }
        public int MentorExperience { get; set; }
        public string MentorTimeslot { get; set; }
        public bool MentorAvailability { get; set; }
        public bool MentorActive { get; set; }
        public IEnumerable<Training> Training { get; set; }
        public IEnumerable<Payment> Payment { get; set; }
    }
}
