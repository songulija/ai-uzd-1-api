using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AI_Uzd_1_API.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Team))]
        public int? TeamId {get;set;}
        public virtual Team Team { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public int Age { get; set; }
        public double JumpHeight { get; set; }
        public double Speed { get; set; }
        public double ReactionTime { get; set; }
    }
}
