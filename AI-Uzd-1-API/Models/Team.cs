using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AI_Uzd_1_API.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        public string Sport { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Player> Players { get; set; }
    }
}
