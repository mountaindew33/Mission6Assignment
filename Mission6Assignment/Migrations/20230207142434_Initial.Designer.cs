﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission6Assignment.Models;

namespace Mission6Assignment.Migrations
{
    [DbContext(typeof(MoviesContext))]
    [Migration("20230207142434_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission6Assignment.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Action"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Adventure"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Sports"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Thriller"
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryName = "Fantasy"
                        },
                        new
                        {
                            CategoryId = 9,
                            CategoryName = "Mystery"
                        });
                });

            modelBuilder.Entity("Mission6Assignment.Models.MoviesResponse", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CategoryId = 1,
                            Director = "Sam Mendes",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "Skyfall",
                            Year = 2012
                        },
                        new
                        {
                            MovieId = 2,
                            CategoryId = 3,
                            Director = "Gabriele Muccino",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "The Pursuit of Happyness",
                            Year = 2006
                        },
                        new
                        {
                            MovieId = 3,
                            CategoryId = 1,
                            Director = "Jon Watts",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "Spider-Man: No Way Home",
                            Year = 2021
                        });
                });

            modelBuilder.Entity("Mission6Assignment.Models.MoviesResponse", b =>
                {
                    b.HasOne("Mission6Assignment.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}