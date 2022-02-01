using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AI_Uzd_1_API.ModelsDTO
{
    public class CreateTeamDTO
    {
        public int SportId { get; set; }
        public string Title { get; set; }
        
    }
    public class UpdateTeamDTO : CreateTeamDTO
    {
    }
    public class TeamDTO : CreateTeamDTO
    {
        public int Id { get; set; }
        public SportDTO Sport { get; set; }
        public virtual IList<PlayerDTO> Players { get; set; }
    }
}
