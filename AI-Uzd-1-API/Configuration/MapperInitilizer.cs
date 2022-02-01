using AI_Uzd_1_API.Models;
using AI_Uzd_1_API.ModelsDTO;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AI_Uzd_1_API.Configuration
{
    public class MapperInitilizer : Profile
    {
        public MapperInitilizer()
        {
            CreateMap<Sport, SportDTO>().ReverseMap();
            CreateMap<Sport, UpdateSportDTO>().ReverseMap();
            CreateMap<Sport, CreateSportDTO>().ReverseMap();

            CreateMap<Team, TeamDTO>().ReverseMap();
            CreateMap<Team, UpdateTeamDTO>().ReverseMap();
            CreateMap<Team, CreateTeamDTO>().ReverseMap();

            CreateMap<Player, PlayerDTO>().ReverseMap();
            CreateMap<Player, UpdatePlayerDTO>().ReverseMap();
            CreateMap<Player, CreatePlayerDTO>().ReverseMap();
        }
    }
}
