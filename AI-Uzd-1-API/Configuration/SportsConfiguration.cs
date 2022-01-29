using AI_Uzd_1_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AI_Uzd_1_API.Configuration
{
    public class SportsConfiguration : IEntityTypeConfiguration<Sport>
    {
        public void Configure(EntityTypeBuilder<Sport> builder)
        {
            builder.HasData(
                new Sport
                {
                    Id = 1,
                    Title = "Krepšinis"
                },
                new Sport
                {
                    Id = 2,
                    Title = "Futbolas"
                }
            );
        }
    }
}
