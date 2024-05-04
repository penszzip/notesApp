﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using notesApp.Models;

#nullable disable

namespace notesApp.Migrations
{
    [DbContext(typeof(NoteDbContext))]
    [Migration("20240504032802_AddSeedDatav2")]
    partial class AddSeedDatav2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("notesApp.Models.NoteItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NoteItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2024, 5, 3, 23, 28, 1, 767, DateTimeKind.Local).AddTicks(8535),
                            Text = "First note"
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2024, 5, 3, 23, 28, 1, 767, DateTimeKind.Local).AddTicks(8586),
                            Text = "Second note"
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2024, 5, 3, 23, 28, 1, 767, DateTimeKind.Local).AddTicks(8588),
                            Text = "Third note"
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2024, 5, 3, 23, 28, 1, 767, DateTimeKind.Local).AddTicks(8589),
                            Text = "Fourth note"
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2024, 5, 3, 23, 28, 1, 767, DateTimeKind.Local).AddTicks(8591),
                            Text = "Fifth note"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
