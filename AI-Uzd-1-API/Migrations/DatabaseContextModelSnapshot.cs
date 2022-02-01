﻿// <auto-generated />
using System;
using AI_Uzd_1_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AI_Uzd_1_API.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AI_Uzd_1_API.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeamId")
                        .HasColumnType("int");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Height = 199,
                            Name = "Thibaut Courtois",
                            Position = "Gynejas",
                            TeamId = 2,
                            Weight = 96
                        },
                        new
                        {
                            Id = 2,
                            Height = 173,
                            Name = "Dani Carvajal",
                            Position = "Gynejas",
                            TeamId = 2,
                            Weight = 73
                        },
                        new
                        {
                            Id = 3,
                            Height = 184,
                            Name = "Sergio Ramos",
                            Position = "Gynejas",
                            TeamId = 2,
                            Weight = 85
                        },
                        new
                        {
                            Id = 4,
                            Height = 186,
                            Name = "Eder Militao",
                            Position = "Gynejas",
                            TeamId = 2,
                            Weight = 79
                        },
                        new
                        {
                            Id = 5,
                            Height = 191,
                            Name = "Raphaël Varane",
                            Position = "Gynejas",
                            TeamId = 2,
                            Weight = 81
                        },
                        new
                        {
                            Id = 6,
                            Height = 180,
                            Name = "José Ignacio Fernández Iglesias",
                            Position = "Gynejas",
                            TeamId = 2,
                            Weight = 76
                        },
                        new
                        {
                            Id = 7,
                            Height = 175,
                            Name = "Eden Hazard",
                            Position = "Puolejas",
                            TeamId = 2,
                            Weight = 75
                        },
                        new
                        {
                            Id = 8,
                            Height = 183,
                            Name = "Toni Kroos",
                            Position = "Puolejas",
                            TeamId = 2,
                            Weight = 76
                        },
                        new
                        {
                            Id = 9,
                            Height = 187,
                            Name = "Karim Benzema",
                            Position = "Puolejas",
                            TeamId = 2,
                            Weight = 85
                        },
                        new
                        {
                            Id = 10,
                            Height = 174,
                            Name = "Luka Modrić",
                            Position = "Puolejas",
                            TeamId = 2,
                            Weight = 66
                        },
                        new
                        {
                            Id = 11,
                            Height = 182,
                            Name = "Marco Asensio",
                            Position = "Puolejas",
                            TeamId = 2,
                            Weight = 75
                        },
                        new
                        {
                            Id = 13,
                            Height = 209,
                            Name = "Marek Blaževič",
                            Position = "Puolejas",
                            TeamId = 1,
                            Weight = 114
                        },
                        new
                        {
                            Id = 14,
                            Height = 196,
                            Name = "Mantas Kalnietis",
                            Position = "Gynejas",
                            TeamId = 1,
                            Weight = 90
                        },
                        new
                        {
                            Id = 15,
                            Height = 206,
                            Name = "Regimantas Miniotas",
                            Position = "Puolejas",
                            TeamId = 1,
                            Weight = 105
                        },
                        new
                        {
                            Id = 16,
                            Height = 201,
                            Name = "Niels Giffey",
                            Position = "Puolejas",
                            TeamId = 1,
                            Weight = 93
                        },
                        new
                        {
                            Id = 17,
                            Height = 195,
                            Name = "Artūras Milaknis",
                            Position = "Gynejas",
                            TeamId = 1,
                            Weight = 90
                        },
                        new
                        {
                            Id = 18,
                            Height = 205,
                            Name = "Paulius Jankūnas",
                            Position = "Puolejas",
                            TeamId = 1,
                            Weight = 113
                        },
                        new
                        {
                            Id = 19,
                            Height = 190,
                            Name = "Titas Sargiūnas",
                            Position = "Gynejas",
                            TeamId = 1,
                            Weight = 82
                        },
                        new
                        {
                            Id = 20,
                            Height = 211,
                            Name = "Joffrey Lauvergne",
                            Position = "Puolejas",
                            TeamId = 1,
                            Weight = 118
                        });
                });

            modelBuilder.Entity("AI_Uzd_1_API.Models.Sport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sport");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "Krepšinis"
                        },
                        new
                        {
                            Id = 2,
                            Title = "Futbolas"
                        });
                });

            modelBuilder.Entity("AI_Uzd_1_API.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SportId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SportId");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            SportId = 1,
                            Title = "Žalgiris"
                        },
                        new
                        {
                            Id = 2,
                            SportId = 2,
                            Title = "Real Madrid"
                        });
                });

            modelBuilder.Entity("AI_Uzd_1_API.Models.Player", b =>
                {
                    b.HasOne("AI_Uzd_1_API.Models.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("AI_Uzd_1_API.Models.Team", b =>
                {
                    b.HasOne("AI_Uzd_1_API.Models.Sport", "Sport")
                        .WithMany("Teams")
                        .HasForeignKey("SportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sport");
                });

            modelBuilder.Entity("AI_Uzd_1_API.Models.Sport", b =>
                {
                    b.Navigation("Teams");
                });

            modelBuilder.Entity("AI_Uzd_1_API.Models.Team", b =>
                {
                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
