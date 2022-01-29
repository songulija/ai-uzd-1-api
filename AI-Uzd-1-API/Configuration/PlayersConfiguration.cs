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
                    Height = 199,
                    Weight = 96,

                }
            );
        }
    }
}
