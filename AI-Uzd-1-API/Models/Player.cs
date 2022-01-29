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
        public string Name { get; set; }
        [ForeignKey(nameof(Team))]
        public int? TeamId {get;set;}
        public virtual Team Team { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public string Position { get; set; }
    }
}
