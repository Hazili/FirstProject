﻿// <auto-generated />
using System;
using DAL.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220705214048_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Entity.Entities.ArrivalCity", b =>
                {
                    b.Property<int>("ArrivalCityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ArrivalCityName")
                        .HasColumnType("text");

                    b.HasKey("ArrivalCityId");

                    b.ToTable("ArrivalCities");
                });

            modelBuilder.Entity("Entity.Entities.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CityName")
                        .HasColumnType("text");

                    b.Property<int?>("FlyId")
                        .HasColumnType("integer");

                    b.HasKey("CityId");

                    b.HasIndex("FlyId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Entity.Entities.DepartureCity", b =>
                {
                    b.Property<int>("DepartureCityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("DepartureCityName")
                        .HasColumnType("text");

                    b.HasKey("DepartureCityId");

                    b.ToTable("DepartureCities");
                });

            modelBuilder.Entity("Entity.Entities.Fly", b =>
                {
                    b.Property<int>("FlyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Airport_1")
                        .HasColumnType("text");

                    b.Property<string>("Airport_2")
                        .HasColumnType("text");

                    b.Property<string>("ArrivalCityName")
                        .HasColumnType("text");

                    b.Property<int>("Capacity")
                        .HasColumnType("integer");

                    b.Property<int>("CityId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("DepartureCityName")
                        .HasColumnType("text");

                    b.Property<string>("FlySeries")
                        .HasColumnType("text");

                    b.Property<int>("NumberOfTicket")
                        .HasColumnType("integer");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.Property<string>("Terminal")
                        .HasColumnType("text");

                    b.HasKey("FlyId");

                    b.ToTable("Flies");
                });

            modelBuilder.Entity("Entity.Entities.Passenger", b =>
                {
                    b.Property<int?>("PassengerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("FlyId")
                        .HasColumnType("integer");

                    b.Property<string>("PassengerName")
                        .HasColumnType("text");

                    b.Property<string>("PassengerPassportNo")
                        .HasMaxLength(9)
                        .HasColumnType("character varying(9)");

                    b.Property<string>("PassengerSurname")
                        .HasColumnType("text");

                    b.HasKey("PassengerId");

                    b.HasIndex("FlyId");

                    b.ToTable("Passengers");
                });

            modelBuilder.Entity("Entity.Entities.PilotGalery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("FullName")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PilotGaleries");
                });

            modelBuilder.Entity("Entity.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("EmailAdress")
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.Property<string>("UserPassword")
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Entity.Entities.City", b =>
                {
                    b.HasOne("Entity.Entities.Fly", null)
                        .WithMany("City")
                        .HasForeignKey("FlyId");
                });

            modelBuilder.Entity("Entity.Entities.Passenger", b =>
                {
                    b.HasOne("Entity.Entities.Fly", "Fly")
                        .WithMany()
                        .HasForeignKey("FlyId");

                    b.Navigation("Fly");
                });

            modelBuilder.Entity("Entity.Entities.Fly", b =>
                {
                    b.Navigation("City");
                });
#pragma warning restore 612, 618
        }
    }
}
