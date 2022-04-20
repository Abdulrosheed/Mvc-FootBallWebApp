﻿// <auto-generated />
using System;
using FootballWebApp.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FootballWebApp.Migrations
{
    [DbContext(typeof(FootBallApplicationDbContext))]
    partial class FootBallApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("FootballWebApp.Entities.Club", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClubBiggestRival")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.Property<string>("ClubCoachName")
                        .HasColumnType("text");

                    b.Property<DateTime>("ClubFoundationDate")
                        .HasColumnType("datetime");

                    b.Property<string>("ClubManagerName")
                        .HasColumnType("text");

                    b.Property<string>("ClubName")
                        .IsRequired()
                        .HasColumnType("Varchar(20)");

                    b.Property<string>("ClubNickName")
                        .IsRequired()
                        .HasColumnType("Varchar(20)");

                    b.Property<int>("ClubNumberOfTrophies")
                        .HasColumnType("int(20)");

                    b.Property<string>("ClubRegistrationNumber")
                        .IsRequired()
                        .HasColumnType("Varchar(20)");

                    b.Property<int>("StadiumCapacity")
                        .HasColumnType("int");

                    b.Property<string>("StadiumName")
                        .IsRequired()
                        .HasColumnType("Varchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("ClubName")
                        .IsUnique();

                    b.HasIndex("ClubNickName")
                        .IsUnique();

                    b.HasIndex("ClubRegistrationNumber")
                        .IsUnique();

                    b.HasIndex("StadiumName")
                        .IsUnique();

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("FootballWebApp.Entities.ClubSponsorer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClubId")
                        .HasColumnType("int");

                    b.Property<int>("SponsorerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.HasIndex("SponsorerId");

                    b.ToTable("ClubSponsorers");
                });

            modelBuilder.Entity("FootballWebApp.Entities.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("ClubId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ContractExpiryDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("DateTime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("Varchar(20)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("Varchar(20)");

                    b.Property<int>("JerseyNumber")
                        .HasColumnType("int(20)");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("Varchar(20)");

                    b.Property<string>("PlayerPhoto")
                        .IsRequired()
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("PlayingPosition")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("StrongFoot")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<decimal>("WeeklySalary")
                        .HasColumnType("decimal(50)");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("PlayerPhoto")
                        .IsUnique();

                    b.ToTable("Players");
                });

            modelBuilder.Entity("FootballWebApp.Entities.Sponsorer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<decimal>("NetWorth")
                        .HasColumnType("decimal(30)");

                    b.Property<string>("RegistrationNumber")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.Property<string>("SponsorerNumberOfCompanies")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("RegistrationNumber")
                        .IsUnique();

                    b.ToTable("Sponsorer");
                });

            modelBuilder.Entity("FootballWebApp.Entities.ClubSponsorer", b =>
                {
                    b.HasOne("FootballWebApp.Entities.Club", "Club")
                        .WithMany("clubSponsors")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FootballWebApp.Entities.Sponsorer", "Sponsorer")
                        .WithMany("clubSponsors")
                        .HasForeignKey("SponsorerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Club");

                    b.Navigation("Sponsorer");
                });

            modelBuilder.Entity("FootballWebApp.Entities.Player", b =>
                {
                    b.HasOne("FootballWebApp.Entities.Club", "Club")
                        .WithMany("players")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Club");
                });

            modelBuilder.Entity("FootballWebApp.Entities.Club", b =>
                {
                    b.Navigation("clubSponsors");

                    b.Navigation("players");
                });

            modelBuilder.Entity("FootballWebApp.Entities.Sponsorer", b =>
                {
                    b.Navigation("clubSponsors");
                });
#pragma warning restore 612, 618
        }
    }
}
