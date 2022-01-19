﻿// <auto-generated />
using GameApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GameApi.Solution.Migrations
{
    [DbContext(typeof(GameApiContext))]
    [Migration("20220119231624_Tile")]
    partial class Tile
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("GameApi.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("x")
                        .HasColumnType("int");

                    b.Property<int>("y")
                        .HasColumnType("int");

                    b.Property<int>("z")
                        .HasColumnType("int");

                    b.HasKey("PlayerId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("GameApi.Models.Tile", b =>
                {
                    b.Property<int>("TileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("Transparent")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("TileId");

                    b.ToTable("Tiles");

                    b.HasData(
                        new
                        {
                            TileId = 1,
                            Name = "floor",
                            Transparent = true
                        },
                        new
                        {
                            TileId = 2,
                            Name = "wall",
                            Transparent = false
                        },
                        new
                        {
                            TileId = 3,
                            Name = "player",
                            Transparent = false
                        });
                });

            modelBuilder.Entity("GameApi.Models.TilePosition", b =>
                {
                    b.Property<int>("TilePositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("TileId")
                        .HasColumnType("int");

                    b.Property<int>("x")
                        .HasColumnType("int");

                    b.Property<int>("y")
                        .HasColumnType("int");

                    b.Property<int>("z")
                        .HasColumnType("int");

                    b.HasKey("TilePositionId");

                    b.HasIndex("TileId");

                    b.ToTable("ZaWorldo");

                    b.HasData(
                        new
                        {
                            TilePositionId = 1,
                            TileId = 2,
                            x = 0,
                            y = 6,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 8,
                            TileId = 2,
                            x = 1,
                            y = 6,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 15,
                            TileId = 2,
                            x = 2,
                            y = 6,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 22,
                            TileId = 2,
                            x = 3,
                            y = 6,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 29,
                            TileId = 2,
                            x = 4,
                            y = 6,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 36,
                            TileId = 2,
                            x = 5,
                            y = 6,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 43,
                            TileId = 2,
                            x = 6,
                            y = 6,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 2,
                            TileId = 2,
                            x = 0,
                            y = 5,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 9,
                            TileId = 1,
                            x = 1,
                            y = 5,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 16,
                            TileId = 1,
                            x = 2,
                            y = 5,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 23,
                            TileId = 1,
                            x = 3,
                            y = 5,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 30,
                            TileId = 1,
                            x = 4,
                            y = 5,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 37,
                            TileId = 1,
                            x = 5,
                            y = 5,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 44,
                            TileId = 2,
                            x = 6,
                            y = 5,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 3,
                            TileId = 2,
                            x = 0,
                            y = 4,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 10,
                            TileId = 1,
                            x = 1,
                            y = 4,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 17,
                            TileId = 1,
                            x = 2,
                            y = 4,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 24,
                            TileId = 1,
                            x = 3,
                            y = 4,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 31,
                            TileId = 1,
                            x = 4,
                            y = 4,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 38,
                            TileId = 1,
                            x = 5,
                            y = 4,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 45,
                            TileId = 2,
                            x = 6,
                            y = 4,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 4,
                            TileId = 2,
                            x = 0,
                            y = 3,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 11,
                            TileId = 1,
                            x = 1,
                            y = 3,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 18,
                            TileId = 1,
                            x = 2,
                            y = 3,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 25,
                            TileId = 1,
                            x = 3,
                            y = 3,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 32,
                            TileId = 1,
                            x = 4,
                            y = 3,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 39,
                            TileId = 1,
                            x = 5,
                            y = 3,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 46,
                            TileId = 2,
                            x = 6,
                            y = 3,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 5,
                            TileId = 2,
                            x = 0,
                            y = 2,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 12,
                            TileId = 1,
                            x = 1,
                            y = 2,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 19,
                            TileId = 1,
                            x = 2,
                            y = 2,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 26,
                            TileId = 1,
                            x = 3,
                            y = 2,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 33,
                            TileId = 1,
                            x = 4,
                            y = 2,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 40,
                            TileId = 1,
                            x = 5,
                            y = 2,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 47,
                            TileId = 2,
                            x = 6,
                            y = 2,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 6,
                            TileId = 2,
                            x = 0,
                            y = 1,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 13,
                            TileId = 1,
                            x = 1,
                            y = 1,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 20,
                            TileId = 1,
                            x = 2,
                            y = 1,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 27,
                            TileId = 1,
                            x = 3,
                            y = 1,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 34,
                            TileId = 1,
                            x = 4,
                            y = 1,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 41,
                            TileId = 1,
                            x = 5,
                            y = 1,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 48,
                            TileId = 2,
                            x = 6,
                            y = 1,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 7,
                            TileId = 2,
                            x = 0,
                            y = 0,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 14,
                            TileId = 2,
                            x = 1,
                            y = 0,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 21,
                            TileId = 2,
                            x = 2,
                            y = 0,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 28,
                            TileId = 2,
                            x = 3,
                            y = 0,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 35,
                            TileId = 2,
                            x = 4,
                            y = 0,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 42,
                            TileId = 2,
                            x = 5,
                            y = 0,
                            z = 0
                        },
                        new
                        {
                            TilePositionId = 49,
                            TileId = 2,
                            x = 6,
                            y = 0,
                            z = 0
                        });
                });

            modelBuilder.Entity("GameApi.Models.TilePosition", b =>
                {
                    b.HasOne("GameApi.Models.Tile", "Tile")
                        .WithMany()
                        .HasForeignKey("TileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tile");
                });
#pragma warning restore 612, 618
        }
    }
}
