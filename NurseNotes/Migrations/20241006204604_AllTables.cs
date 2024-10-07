using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NurseNotes.Migrations
{
    /// <inheritdoc />
    public partial class AllTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FCHCREATION",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateTable(
                name: "Diagnosis",
                columns: table => new
                {
                    DIAG_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DIAGDSC = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnosis", x => x.DIAG_ID);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    GRP_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GRPDSC = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.GRP_ID);
                });

            migrationBuilder.CreateTable(
                name: "Headquearters",
                columns: table => new
                {
                    HEADQ_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HEADQDSC = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Headquearters", x => x.HEADQ_ID);
                });

            migrationBuilder.CreateTable(
                name: "Medications",
                columns: table => new
                {
                    MED_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MEDDSC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    STOCK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medications", x => x.MED_ID);
                });

            migrationBuilder.CreateTable(
                name: "Permitions",
                columns: table => new
                {
                    PER_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PERDSC = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permitions", x => x.PER_ID);
                });

            migrationBuilder.CreateTable(
                name: "Specialities",
                columns: table => new
                {
                    SPEC_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SPECDSC = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialities", x => x.SPEC_ID);
                });

            migrationBuilder.CreateTable(
                name: "TipDocs",
                columns: table => new
                {
                    TIPDOC_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TIPDOCDSC = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipDocs", x => x.TIPDOC_ID);
                });

            migrationBuilder.CreateTable(
                name: "UsersLogs",
                columns: table => new
                {
                    LOG_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USR_ID = table.Column<int>(type: "int", nullable: false),
                    FCHMOD = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    USRMOD = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersLogs", x => x.LOG_ID);
                    table.ForeignKey(
                        name: "FK_UsersLogs_Users_USR_ID",
                        column: x => x.USR_ID,
                        principalTable: "Users",
                        principalColumn: "USR_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PerXGroups",
                columns: table => new
                {
                    PG_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GRP_ID = table.Column<int>(type: "int", nullable: false),
                    PER_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerXGroups", x => x.PG_ID);
                    table.ForeignKey(
                        name: "FK_PerXGroups_Groups_GRP_ID",
                        column: x => x.GRP_ID,
                        principalTable: "Groups",
                        principalColumn: "GRP_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PerXGroups_Permitions_PER_ID",
                        column: x => x.PER_ID,
                        principalTable: "Permitions",
                        principalColumn: "PER_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    STAFF_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MEDSTAFF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SPEC_ID = table.Column<int>(type: "int", nullable: false),
                    HEADQ_ID = table.Column<int>(type: "int", nullable: false),
                    USR_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.STAFF_ID);
                    table.ForeignKey(
                        name: "FK_Staffs_Headquearters_HEADQ_ID",
                        column: x => x.HEADQ_ID,
                        principalTable: "Headquearters",
                        principalColumn: "HEADQ_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Staffs_Specialities_SPEC_ID",
                        column: x => x.SPEC_ID,
                        principalTable: "Specialities",
                        principalColumn: "SPEC_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Staffs_Users_USR_ID",
                        column: x => x.USR_ID,
                        principalTable: "Users",
                        principalColumn: "USR_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PATIENT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LASTNAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TIPDOC_ID = table.Column<int>(type: "int", nullable: false),
                    NUMDOC = table.Column<int>(type: "int", nullable: false),
                    AGE = table.Column<int>(type: "int", nullable: false),
                    NUMCONTACT = table.Column<int>(type: "int", nullable: false),
                    MAIL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PATIENT_ID);
                    table.ForeignKey(
                        name: "FK_Patients_TipDocs_TIPDOC_ID",
                        column: x => x.TIPDOC_ID,
                        principalTable: "TipDocs",
                        principalColumn: "TIPDOC_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Incomes",
                columns: table => new
                {
                    INCOME_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TIPDOC_ID = table.Column<int>(type: "int", nullable: false),
                    PATIENT_ID = table.Column<int>(type: "int", nullable: false),
                    FCHINCOME = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    USR_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incomes", x => x.INCOME_ID);
                    table.ForeignKey(
                        name: "FK_Incomes_Patients_PATIENT_ID",
                        column: x => x.PATIENT_ID,
                        principalTable: "Patients",
                        principalColumn: "PATIENT_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incomes_TipDocs_TIPDOC_ID",
                        column: x => x.TIPDOC_ID,
                        principalTable: "TipDocs",
                        principalColumn: "TIPDOC_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incomes_Users_USR_ID",
                        column: x => x.USR_ID,
                        principalTable: "Users",
                        principalColumn: "USR_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NurseNotes",
                columns: table => new
                {
                    NOTE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    INCOME_ID = table.Column<int>(type: "int", nullable: false),
                    PATIENT_ID = table.Column<int>(type: "int", nullable: false),
                    REASONCONS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DIAG_ID = table.Column<int>(type: "int", nullable: false),
                    SPEC_ID = table.Column<int>(type: "int", nullable: false),
                    USR_ID = table.Column<int>(type: "int", nullable: false),
                    STAFF_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NurseNotes", x => x.NOTE_ID);
                    table.ForeignKey(
                        name: "FK_NurseNotes_Diagnosis_DIAG_ID",
                        column: x => x.DIAG_ID,
                        principalTable: "Diagnosis",
                        principalColumn: "DIAG_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NurseNotes_Incomes_INCOME_ID",
                        column: x => x.INCOME_ID,
                        principalTable: "Incomes",
                        principalColumn: "INCOME_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NurseNotes_Patients_PATIENT_ID",
                        column: x => x.PATIENT_ID,
                        principalTable: "Patients",
                        principalColumn: "PATIENT_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NurseNotes_Specialities_SPEC_ID",
                        column: x => x.SPEC_ID,
                        principalTable: "Specialities",
                        principalColumn: "SPEC_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NurseNotes_Staffs_STAFF_ID",
                        column: x => x.STAFF_ID,
                        principalTable: "Staffs",
                        principalColumn: "STAFF_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NurseNotes_Users_USR_ID",
                        column: x => x.USR_ID,
                        principalTable: "Users",
                        principalColumn: "USR_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PatientRecords",
                columns: table => new
                {
                    PATR_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ALLERGIES = table.Column<bool>(type: "bit", nullable: true),
                    ALLERG_DSC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SURGERIES = table.Column<bool>(type: "bit", nullable: true),
                    SURGER_DSC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    INCOME_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientRecords", x => x.PATR_ID);
                    table.ForeignKey(
                        name: "FK_PatientRecords_Incomes_INCOME_ID",
                        column: x => x.INCOME_ID,
                        principalTable: "Incomes",
                        principalColumn: "INCOME_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SuppliesPatients",
                columns: table => new
                {
                    SUP_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CANTSUP = table.Column<int>(type: "int", nullable: false),
                    INCOME_ID = table.Column<int>(type: "int", nullable: false),
                    MED_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuppliesPatients", x => x.SUP_ID);
                    table.ForeignKey(
                        name: "FK_SuppliesPatients_Incomes_INCOME_ID",
                        column: x => x.INCOME_ID,
                        principalTable: "Incomes",
                        principalColumn: "INCOME_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SuppliesPatients_Medications_MED_ID",
                        column: x => x.MED_ID,
                        principalTable: "Medications",
                        principalColumn: "MED_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Signs",
                columns: table => new
                {
                    SIGN_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NurseNoteNOTE_ID = table.Column<int>(type: "int", nullable: false),
                    TEMPERATURE = table.Column<int>(type: "int", nullable: false),
                    PULSE = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Signs", x => x.SIGN_ID);
                    table.ForeignKey(
                        name: "FK_Signs_NurseNotes_NurseNoteNOTE_ID",
                        column: x => x.NurseNoteNOTE_ID,
                        principalTable: "NurseNotes",
                        principalColumn: "NOTE_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Folios",
                columns: table => new
                {
                    FOLIO_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    INCOME_ID = table.Column<int>(type: "int", nullable: false),
                    NOTE_ID = table.Column<int>(type: "int", nullable: false),
                    SUP_ID = table.Column<int>(type: "int", nullable: false),
                    USR_ID = table.Column<int>(type: "int", nullable: false),
                    EVOLUTION = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Folios", x => x.FOLIO_ID);
                    table.ForeignKey(
                        name: "FK_Folios_Incomes_INCOME_ID",
                        column: x => x.INCOME_ID,
                        principalTable: "Incomes",
                        principalColumn: "INCOME_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Folios_NurseNotes_NOTE_ID",
                        column: x => x.NOTE_ID,
                        principalTable: "NurseNotes",
                        principalColumn: "NOTE_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Folios_SuppliesPatients_SUP_ID",
                        column: x => x.SUP_ID,
                        principalTable: "SuppliesPatients",
                        principalColumn: "SUP_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Folios_Users_USR_ID",
                        column: x => x.USR_ID,
                        principalTable: "Users",
                        principalColumn: "USR_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_GRP_ID",
                table: "Users",
                column: "GRP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Folios_INCOME_ID",
                table: "Folios",
                column: "INCOME_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Folios_NOTE_ID",
                table: "Folios",
                column: "NOTE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Folios_SUP_ID",
                table: "Folios",
                column: "SUP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Folios_USR_ID",
                table: "Folios",
                column: "USR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Incomes_PATIENT_ID",
                table: "Incomes",
                column: "PATIENT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Incomes_TIPDOC_ID",
                table: "Incomes",
                column: "TIPDOC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Incomes_USR_ID",
                table: "Incomes",
                column: "USR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_NurseNotes_DIAG_ID",
                table: "NurseNotes",
                column: "DIAG_ID");

            migrationBuilder.CreateIndex(
                name: "IX_NurseNotes_INCOME_ID",
                table: "NurseNotes",
                column: "INCOME_ID");

            migrationBuilder.CreateIndex(
                name: "IX_NurseNotes_PATIENT_ID",
                table: "NurseNotes",
                column: "PATIENT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_NurseNotes_SPEC_ID",
                table: "NurseNotes",
                column: "SPEC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_NurseNotes_STAFF_ID",
                table: "NurseNotes",
                column: "STAFF_ID");

            migrationBuilder.CreateIndex(
                name: "IX_NurseNotes_USR_ID",
                table: "NurseNotes",
                column: "USR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecords_INCOME_ID",
                table: "PatientRecords",
                column: "INCOME_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_TIPDOC_ID",
                table: "Patients",
                column: "TIPDOC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PerXGroups_GRP_ID",
                table: "PerXGroups",
                column: "GRP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PerXGroups_PER_ID",
                table: "PerXGroups",
                column: "PER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Signs_NurseNoteNOTE_ID",
                table: "Signs",
                column: "NurseNoteNOTE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_HEADQ_ID",
                table: "Staffs",
                column: "HEADQ_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_SPEC_ID",
                table: "Staffs",
                column: "SPEC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_USR_ID",
                table: "Staffs",
                column: "USR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SuppliesPatients_INCOME_ID",
                table: "SuppliesPatients",
                column: "INCOME_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SuppliesPatients_MED_ID",
                table: "SuppliesPatients",
                column: "MED_ID");

            migrationBuilder.CreateIndex(
                name: "IX_UsersLogs_USR_ID",
                table: "UsersLogs",
                column: "USR_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Groups_GRP_ID",
                table: "Users",
                column: "GRP_ID",
                principalTable: "Groups",
                principalColumn: "GRP_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Groups_GRP_ID",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Folios");

            migrationBuilder.DropTable(
                name: "PatientRecords");

            migrationBuilder.DropTable(
                name: "PerXGroups");

            migrationBuilder.DropTable(
                name: "Signs");

            migrationBuilder.DropTable(
                name: "UsersLogs");

            migrationBuilder.DropTable(
                name: "SuppliesPatients");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Permitions");

            migrationBuilder.DropTable(
                name: "NurseNotes");

            migrationBuilder.DropTable(
                name: "Medications");

            migrationBuilder.DropTable(
                name: "Diagnosis");

            migrationBuilder.DropTable(
                name: "Incomes");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Headquearters");

            migrationBuilder.DropTable(
                name: "Specialities");

            migrationBuilder.DropTable(
                name: "TipDocs");

            migrationBuilder.DropIndex(
                name: "IX_Users_GRP_ID",
                table: "Users");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FCHCREATION",
                table: "Users",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETDATE()");
        }
    }
}
