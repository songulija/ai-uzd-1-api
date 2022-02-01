using AI_Uzd_1_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AI_Uzd_1_API.Configuration
{
    //first footbal team madrid players then basketball zalgiris players
    public class PlayersConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.HasData(
                new Player
                {
                    Id = 1,
                    TeamId = 2,
                    Height = 199,
                    Weight = 96,
                    Name = "Thibaut Courtois",
                    Position = "Gynejas"
                },
                new Player
                {
                    Id = 2,
                    TeamId = 2,
                    Height = 173,
                    Weight = 73,
                    Name = "Dani Carvajal",
                    Position = "Gynejas"
                },
                new Player
                {
                    Id = 3,
                    TeamId = 2,
                    Height = 184,
                    Weight = 85,
                    Name = "Sergio Ramos",
                    Position = "Gynejas"
                },
                new Player
                {
                    Id = 4,
                    TeamId = 2,
                    Height = 186,
                    Weight = 79,
                    Name = "Eder Militao",
                    Position = "Gynejas"
                },
                new Player
                {
                    Id = 5,
                    TeamId = 2,
                    Height = 191,
                    Weight = 81,
                    Name = "Raphaël Varane",
                    Position = "Gynejas"
                },
                new Player
                {
                    Id = 6,
                    TeamId = 2,
                    Height = 180,
                    Weight = 76,
                    Name = "José Ignacio Fernández Iglesias",
                    Position = "Gynejas"
                },
                new Player
                {
                    Id = 7,
                    TeamId = 2,
                    Height = 175,
                    Weight = 75,
                    Name = "Eden Hazard",
                    Position = "Puolejas"
                },
                new Player
                {
                    Id = 8,
                    TeamId = 2,
                    Height = 183,
                    Weight = 76,
                    Name = "Toni Kroos",
                    Position = "Puolejas"
                },
                new Player
                {
                    Id = 9,
                    TeamId = 2,
                    Height = 187,
                    Weight = 85,
                    Name = "Karim Benzema",
                    Position = "Puolejas"
                },
                new Player
                {
                    Id = 10,
                    TeamId = 2,
                    Height = 174,
                    Weight = 66,
                    Name = "Luka Modrić",
                    Position = "Puolejas"
                },
                new Player
                {
                    Id = 11,
                    TeamId = 2,
                    Height = 182,
                    Weight = 75,
                    Name = "Marco Asensio",
                    Position = "Puolejas"
                },
                //KREPSINIS
                new Player
                {
                    Id = 13,
                    TeamId = 1,
                    Height = 209,
                    Weight = 114,
                    Name = "Marek Blaževič",
                    Position = "Puolejas"
                },
                new Player
                {
                    Id = 14,
                    TeamId = 1,
                    Height = 196,
                    Weight = 90,
                    Name = "Mantas Kalnietis",
                    Position = "Gynejas"
                },
                new Player
                {
                    Id = 15,
                    TeamId = 1,
                    Height = 206,
                    Weight = 105,
                    Name = "Regimantas Miniotas",
                    Position = "Puolejas"
                },
                new Player
                {
                    Id = 16,
                    TeamId = 1,
                    Height = 201,
                    Weight = 93,
                    Name = "Niels Giffey",
                    Position = "Puolejas"
                },
                new Player
                {
                    Id = 17,
                    TeamId = 1,
                    Height = 195,
                    Weight = 90,
                    Name = "Artūras Milaknis",
                    Position = "Gynejas"
                },
                new Player
                {
                    Id = 18,
                    TeamId = 1,
                    Height = 205,
                    Weight = 113,
                    Name = "Paulius Jankūnas",
                    Position = "Puolejas"
                },
                new Player
                {
                    Id = 19,
                    TeamId = 1,
                    Height = 190,
                    Weight = 82,
                    Name = "Titas Sargiūnas",
                    Position = "Gynejas"
                },
                new Player
                {
                    Id = 20,
                    TeamId = 1,
                    Height = 211,
                    Weight = 118,
                    Name = "Joffrey Lauvergne",
                    Position = "Puolejas"
                }
            );
        }
    }
}
