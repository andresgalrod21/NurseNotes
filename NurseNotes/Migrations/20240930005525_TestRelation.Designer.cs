﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NurseNotes.Context;

#nullable disable

namespace NurseNotes.Migrations
{
    [DbContext(typeof(TestDbNurseNotes))]
    [Migration("20240930005525_TestRelation")]
    partial class TestRelation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NurseNotes.Model.Users", b =>
                {
                    b.Property<int>("USR_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("USR_ID"));

                    b.Property<DateTime>("FCHCREATION")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int>("GRP_ID")
                        .HasColumnType("int");

                    b.Property<string>("LASTNAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NUMDOC")
                        .HasColumnType("int");

                    b.Property<string>("TIPDOC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("USR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("USRPSW")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("USR_ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("NurseNotes.Model.UsersLogs", b =>
                {
                    b.Property<int>("LOG_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LOG_ID"));

                    b.Property<DateTime>("FCHMOD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("USRMOD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsersUSR_ID")
                        .HasColumnType("int");

                    b.HasKey("LOG_ID");

                    b.HasIndex("UsersUSR_ID");

                    b.ToTable("UsersLogs");
                });

            modelBuilder.Entity("NurseNotes.Model.UsersLogs", b =>
                {
                    b.HasOne("NurseNotes.Model.Users", "Users")
                        .WithMany()
                        .HasForeignKey("UsersUSR_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}