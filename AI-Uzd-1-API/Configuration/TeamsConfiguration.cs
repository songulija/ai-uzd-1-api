using AI_Uzd_1_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AI_Uzd_1_API.Configuration
{
    public class TeamsConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasData(
                new Team
                {
                    Id = 1,
                    SportId = 1,
                    Title = "Žalgiris"
                },
                new Team
                {
                    Id = 2,
                    SportId = 2,
                    Title = "Real Madrid"
                }
            );
        }
    }
}
