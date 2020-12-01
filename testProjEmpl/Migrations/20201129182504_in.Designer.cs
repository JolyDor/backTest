﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using testProjEmpl.Models;

namespace testProjEmpl.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20201129182504_in")]
    partial class @in
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("testProjEmpl.Models.Test", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("name")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.HasKey("id")
                        .HasName("Note_PK");

                    b.ToTable("Test");
                });
#pragma warning restore 612, 618
        }
    }
}
