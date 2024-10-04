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
    [Migration("20241003223127_addPatient")]
    partial class addPatient
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NurseNotes.Model.Diagnosis", b =>
                {
                    b.Property<int>("DIAG_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DIAG_ID"));

                    b.Property<string>("DIAGDSC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DIAG_ID");

                    b.ToTable("Diagnosis");
                });

            modelBuilder.Entity("NurseNotes.Model.Folios", b =>
                {
                    b.Property<int>("FOLIO_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FOLIO_ID"));

                    b.Property<string>("EVOLUTION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IncomesINCOME_ID")
                        .HasColumnType("int");

                    b.Property<int>("NurseNoteNOTE_ID")
                        .HasColumnType("int");

                    b.Property<int>("UsersUSR_ID")
                        .HasColumnType("int");

                    b.HasKey("FOLIO_ID");

                    b.HasIndex("IncomesINCOME_ID");

                    b.HasIndex("NurseNoteNOTE_ID");

                    b.HasIndex("UsersUSR_ID");

                    b.ToTable("Folios");
                });

            modelBuilder.Entity("NurseNotes.Model.Groups", b =>
                {
                    b.Property<int>("GRP_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GRP_ID"));

                    b.Property<string>("GRPDSC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GRP_ID");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("NurseNotes.Model.Headquearters", b =>
                {
                    b.Property<int>("HEADQ_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HEADQ_ID"));

                    b.Property<string>("HEADQDSC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HEADQ_ID");

                    b.ToTable("Headquearters");
                });

            modelBuilder.Entity("NurseNotes.Model.Incomes", b =>
                {
                    b.Property<int>("INCOME_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("INCOME_ID"));

                    b.Property<DateTime>("FCHINCOME")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int>("PatientsPATIENT_ID")
                        .HasColumnType("int");

                    b.Property<int>("UsersUSR_ID")
                        .HasColumnType("int");

                    b.HasKey("INCOME_ID");

                    b.HasIndex("PatientsPATIENT_ID");

                    b.HasIndex("UsersUSR_ID");

                    b.ToTable("Incomes");
                });

            modelBuilder.Entity("NurseNotes.Model.Medications", b =>
                {
                    b.Property<int>("MED_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MED_ID"));

                    b.Property<string>("MEDDSC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("STOCK")
                        .HasColumnType("int");

                    b.HasKey("MED_ID");

                    b.ToTable("Medications");
                });

            modelBuilder.Entity("NurseNotes.Model.NurseNote", b =>
                {
                    b.Property<int>("NOTE_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NOTE_ID"));

                    b.Property<int>("DiagnosisDIAG_ID")
                        .HasColumnType("int");

                    b.Property<int>("IncomesINCOME_ID")
                        .HasColumnType("int");

                    b.Property<int>("PatientsPATIENT_ID")
                        .HasColumnType("int");

                    b.Property<string>("REASONCONS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("STAFF_ID")
                        .HasColumnType("int");

                    b.Property<int>("SpecialitiesSPEC_ID")
                        .HasColumnType("int");

                    b.Property<int>("UsersUSR_ID")
                        .HasColumnType("int");

                    b.HasKey("NOTE_ID");

                    b.HasIndex("DiagnosisDIAG_ID");

                    b.HasIndex("IncomesINCOME_ID");

                    b.HasIndex("PatientsPATIENT_ID");

                    b.HasIndex("STAFF_ID");

                    b.HasIndex("SpecialitiesSPEC_ID");

                    b.HasIndex("UsersUSR_ID");

                    b.ToTable("NurseNotes");
                });

            modelBuilder.Entity("NurseNotes.Model.PatientRecords", b =>
                {
                    b.Property<int>("PATR_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PATR_ID"));

                    b.Property<bool?>("ALLERGIES")
                        .HasColumnType("bit");

                    b.Property<string>("ALLERG_DSC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IncomesINCOME_ID")
                        .HasColumnType("int");

                    b.Property<string>("RH")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("SURGERIES")
                        .HasColumnType("bit");

                    b.Property<string>("SURGER_DSC")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PATR_ID");

                    b.HasIndex("IncomesINCOME_ID");

                    b.ToTable("PatientRecords");
                });

            modelBuilder.Entity("NurseNotes.Model.Patients", b =>
                {
                    b.Property<int>("PATIENT_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PATIENT_ID"));

                    b.Property<int>("AGE")
                        .HasColumnType("int");

                    b.Property<string>("LASTNAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MAIL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NUMCONTACT")
                        .HasColumnType("int");

                    b.Property<int>("NUMDOC")
                        .HasColumnType("int");

                    b.Property<int>("TipDocsTIPDOC_ID")
                        .HasColumnType("int");

                    b.HasKey("PATIENT_ID");

                    b.HasIndex("TipDocsTIPDOC_ID");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("NurseNotes.Model.PerXGroups", b =>
                {
                    b.Property<int>("PG_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PG_ID"));

                    b.Property<int>("GroupsGRP_ID")
                        .HasColumnType("int");

                    b.Property<int>("PermitionsPER_ID")
                        .HasColumnType("int");

                    b.HasKey("PG_ID");

                    b.HasIndex("GroupsGRP_ID");

                    b.HasIndex("PermitionsPER_ID");

                    b.ToTable("PerXGroups");
                });

            modelBuilder.Entity("NurseNotes.Model.Permitions", b =>
                {
                    b.Property<int>("PER_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PER_ID"));

                    b.Property<string>("PERDSC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PER_ID");

                    b.ToTable("Permitions");
                });

            modelBuilder.Entity("NurseNotes.Model.Signs", b =>
                {
                    b.Property<int>("SIGN_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SIGN_ID"));

                    b.Property<int>("NurseNoteNOTE_ID")
                        .HasColumnType("int");

                    b.Property<string>("PULSE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TEMPERATURE")
                        .HasColumnType("int");

                    b.HasKey("SIGN_ID");

                    b.HasIndex("NurseNoteNOTE_ID");

                    b.ToTable("Signs");
                });

            modelBuilder.Entity("NurseNotes.Model.Specialities", b =>
                {
                    b.Property<int>("SPEC_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SPEC_ID"));

                    b.Property<string>("SPECDSC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SPEC_ID");

                    b.ToTable("Specialities");
                });

            modelBuilder.Entity("NurseNotes.Model.Staff", b =>
                {
                    b.Property<int>("STAFF_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("STAFF_ID"));

                    b.Property<int>("HeadqueartersHEADQ_ID")
                        .HasColumnType("int");

                    b.Property<string>("MEDSTAFF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpecialitiesSPEC_ID")
                        .HasColumnType("int");

                    b.Property<int>("UsersUSR_ID")
                        .HasColumnType("int");

                    b.HasKey("STAFF_ID");

                    b.HasIndex("HeadqueartersHEADQ_ID");

                    b.HasIndex("SpecialitiesSPEC_ID");

                    b.HasIndex("UsersUSR_ID");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("NurseNotes.Model.SuppliesPatients", b =>
                {
                    b.Property<int>("SUP_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SUP_ID"));

                    b.Property<int>("CANTSUP")
                        .HasColumnType("int");

                    b.Property<int>("IncomesINCOME_ID")
                        .HasColumnType("int");

                    b.Property<int>("MedicationsMED_ID")
                        .HasColumnType("int");

                    b.HasKey("SUP_ID");

                    b.HasIndex("IncomesINCOME_ID");

                    b.HasIndex("MedicationsMED_ID");

                    b.ToTable("SuppliesPatients");
                });

            modelBuilder.Entity("NurseNotes.Model.TipDocs", b =>
                {
                    b.Property<int>("TIPDOC_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TIPDOC_ID"));

                    b.Property<string>("TIPDOCDSC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TIPDOC_ID");

                    b.ToTable("tipDoc");
                });

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

                    b.Property<int>("GroupsGRP_ID")
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

                    b.HasIndex("GroupsGRP_ID");

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

            modelBuilder.Entity("NurseNotes.Model.Folios", b =>
                {
                    b.HasOne("NurseNotes.Model.Incomes", "Incomes")
                        .WithMany()
                        .HasForeignKey("IncomesINCOME_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NurseNotes.Model.NurseNote", "NurseNote")
                        .WithMany()
                        .HasForeignKey("NurseNoteNOTE_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NurseNotes.Model.Users", "Users")
                        .WithMany()
                        .HasForeignKey("UsersUSR_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Incomes");

                    b.Navigation("NurseNote");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("NurseNotes.Model.Incomes", b =>
                {
                    b.HasOne("NurseNotes.Model.Patients", "Patients")
                        .WithMany()
                        .HasForeignKey("PatientsPATIENT_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NurseNotes.Model.Users", "Users")
                        .WithMany()
                        .HasForeignKey("UsersUSR_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patients");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("NurseNotes.Model.NurseNote", b =>
                {
                    b.HasOne("NurseNotes.Model.Diagnosis", "Diagnosis")
                        .WithMany()
                        .HasForeignKey("DiagnosisDIAG_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NurseNotes.Model.Incomes", "Incomes")
                        .WithMany()
                        .HasForeignKey("IncomesINCOME_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NurseNotes.Model.Patients", "Patients")
                        .WithMany()
                        .HasForeignKey("PatientsPATIENT_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NurseNotes.Model.Staff", "Staff")
                        .WithMany()
                        .HasForeignKey("STAFF_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NurseNotes.Model.Specialities", "Specialities")
                        .WithMany()
                        .HasForeignKey("SpecialitiesSPEC_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NurseNotes.Model.Users", "Users")
                        .WithMany()
                        .HasForeignKey("UsersUSR_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Diagnosis");

                    b.Navigation("Incomes");

                    b.Navigation("Patients");

                    b.Navigation("Specialities");

                    b.Navigation("Staff");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("NurseNotes.Model.PatientRecords", b =>
                {
                    b.HasOne("NurseNotes.Model.Incomes", "Incomes")
                        .WithMany()
                        .HasForeignKey("IncomesINCOME_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Incomes");
                });

            modelBuilder.Entity("NurseNotes.Model.Patients", b =>
                {
                    b.HasOne("NurseNotes.Model.TipDocs", "TipDocs")
                        .WithMany()
                        .HasForeignKey("TipDocsTIPDOC_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipDocs");
                });

            modelBuilder.Entity("NurseNotes.Model.PerXGroups", b =>
                {
                    b.HasOne("NurseNotes.Model.Groups", "Groups")
                        .WithMany()
                        .HasForeignKey("GroupsGRP_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NurseNotes.Model.Permitions", "Permitions")
                        .WithMany()
                        .HasForeignKey("PermitionsPER_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Groups");

                    b.Navigation("Permitions");
                });

            modelBuilder.Entity("NurseNotes.Model.Signs", b =>
                {
                    b.HasOne("NurseNotes.Model.NurseNote", "NurseNote")
                        .WithMany()
                        .HasForeignKey("NurseNoteNOTE_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NurseNote");
                });

            modelBuilder.Entity("NurseNotes.Model.Staff", b =>
                {
                    b.HasOne("NurseNotes.Model.Headquearters", "Headquearters")
                        .WithMany()
                        .HasForeignKey("HeadqueartersHEADQ_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NurseNotes.Model.Specialities", "Specialities")
                        .WithMany()
                        .HasForeignKey("SpecialitiesSPEC_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NurseNotes.Model.Users", "Users")
                        .WithMany()
                        .HasForeignKey("UsersUSR_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Headquearters");

                    b.Navigation("Specialities");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("NurseNotes.Model.SuppliesPatients", b =>
                {
                    b.HasOne("NurseNotes.Model.Incomes", "Incomes")
                        .WithMany()
                        .HasForeignKey("IncomesINCOME_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NurseNotes.Model.Medications", "Medications")
                        .WithMany()
                        .HasForeignKey("MedicationsMED_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Incomes");

                    b.Navigation("Medications");
                });

            modelBuilder.Entity("NurseNotes.Model.Users", b =>
                {
                    b.HasOne("NurseNotes.Model.Groups", "Groups")
                        .WithMany()
                        .HasForeignKey("GroupsGRP_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Groups");
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
