﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SmartHotel.Services.Bookings.Data;
using System;

namespace SmartHotel.Services.Bookings.Migrations
{
    [DbContext(typeof(BookingsDbContext))]
    partial class BookingsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SmartHotel.Services.Bookings.Domain.Booking.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("date");

                    b.Property<string>("ClientEmail")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("IdHotel");

                    b.Property<int>("IdRoomType");

                    b.Property<byte>("NumberOfAdults");

                    b.Property<byte>("NumberOfBabies");

                    b.Property<byte>("NumberOfChildren");

                    b.Property<decimal>("TotalCost")
                        .HasColumnType("decimal(7,2)");

                    b.HasKey("Id");

                    b.ToTable("Booking");
                });
#pragma warning restore 612, 618
        }
    }
}
