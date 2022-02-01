using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AI_Uzd_1_API.ModelsDTO
{
    public class CreatePlayerDTO
    {
        public string Name { get; set; }
        public int? TeamId { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public string Position { get; set; }
        public int Knum { get; set; }
    }
    public class UpdatePlayerDTO : CreatePlayerDTO
    {

    }
    public class PlayerDTO : CreatePlayerDTO
    {
        public int Id { get; set; }
        public double? Distance { get; set; }
        public virtual TeamDTO Team { get; set; }
    }
}
