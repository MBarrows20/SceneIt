﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TVTracker.Models;

namespace TVTracker.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20181102010558_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("TVTracker.Models.TVProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DateWatched");

                    b.Property<int>("Episode");

                    b.Property<int>("Season");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("TVProgram");
                });
#pragma warning restore 612, 618
        }
    }
}