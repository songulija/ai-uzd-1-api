using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AI_Uzd_1_API.ModelsDTO
{
    public class CreateSportDTO
    {
        public string Title { get; set; }
    }
    public class UpdateSportDTO : CreateSportDTO
    {
    }
    public class SportDTO : CreateSportDTO
    {
        public int Id { get; set; }
        public virtual IList<TeamDTO> Teams { get; set; }
    }
}
