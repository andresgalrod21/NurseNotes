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
    [Migration("20240924235229_TblUsers")]
    partial class TblUsers
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NurseNotes.Model.IUserRepository+User", b =>
                {
                    b.Property<int>("USR_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("USR_ID"));

                    b.Property<DateTime>("FCHCREATION")
                        .HasColumnType("datetime2");

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
#pragma warning restore 612, 618
        }
    }
}
