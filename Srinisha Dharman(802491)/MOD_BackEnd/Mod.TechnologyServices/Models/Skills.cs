using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mod.TechnologyServices.Models

{ [Table("Skills")]
    public class Skills
    {

        [Key]
        public int SkillId { get; set; }
        
        public string SkillName { get; set; }
        public string Toc { get; set; }
        public double Fee{ get; set; }
        public int Duration { get; set; }
        public IEnumerable<Training> Training { get; set; }

    }
}
