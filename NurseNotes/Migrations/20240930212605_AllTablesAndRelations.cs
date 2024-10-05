using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NurseNotes.Migrations
{
    /// <inheritdoc />
    public partial class AllTablesAndRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GroupsGRP_ID",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipDocsTIPDOC_ID",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DiagnosisDIAG_ID",
                table: "NurseNotes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IncomesINCOME_ID",
                table: "NurseNotes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "STAFF_ID",
                table: "NurseNotes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpecialitiesSPEC_ID",
                table: "NurseNotes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FCHINCOME",
                table: "Incomes",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<int>(
                name: "PatientsPATIENT_ID",
                table: "Incomes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsersUSR_ID",
                table: "Incomes",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                name: "SuppliesPatients",
                columns: table => new
                {
                    SUP_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CANTSUP = table.Column<int>(type: "int", nullable: false),
                    IncomesINCOME_ID = table.Column<int>(type: "int", nullable: false),
                    MedicationsMED_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuppliesPatients", x => x.SUP_ID);
                    table.ForeignKey(
                        name: "FK_SuppliesPatients_Incomes_IncomesINCOME_ID",
                        column: x => x.IncomesINCOME_ID,
                        principalTable: "Incomes",
                        principalColumn: "INCOME_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SuppliesPatients_Medications_MedicationsMED_ID",
                        column: x => x.MedicationsMED_ID,
                        principalTable: "Medications",
                        principalColumn: "MED_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PerXGroups",
                columns: table => new
                {
                    PG_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupsGRP_ID = table.Column<int>(type: "int", nullable: false),
                    PermitionsPER_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerXGroups", x => x.PG_ID);
                    table.ForeignKey(
                        name: "FK_PerXGroups_Groups_GroupsGRP_ID",
                        column: x => x.GroupsGRP_ID,
                        principalTable: "Groups",
                        principalColumn: "GRP_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PerXGroups_Permitions_PermitionsPER_ID",
                        column: x => x.PermitionsPER_ID,
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
                    SpecialitiesSPEC_ID = table.Column<int>(type: "int", nullable: false),
                    HeadqueartersHEADQ_ID = table.Column<int>(type: "int", nullable: false),
                    UsersUSR_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.STAFF_ID);
                    table.ForeignKey(
                        name: "FK_Staffs_Headquearters_HeadqueartersHEADQ_ID",
                        column: x => x.HeadqueartersHEADQ_ID,
                        principalTable: "Headquearters",
                        principalColumn: "HEADQ_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Staffs_Specialities_SpecialitiesSPEC_ID",
                        column: x => x.SpecialitiesSPEC_ID,
                        principalTable: "Specialities",
                        principalColumn: "SPEC_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Staffs_Users_UsersUSR_ID",
                        column: x => x.UsersUSR_ID,
                        principalTable: "Users",
                        principalColumn: "USR_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_GroupsGRP_ID",
                table: "Users",
                column: "GroupsGRP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_TipDocsTIPDOC_ID",
                table: "Patients",
                column: "TipDocsTIPDOC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_NurseNotes_DiagnosisDIAG_ID",
                table: "NurseNotes",
                column: "DiagnosisDIAG_ID");

            migrationBuilder.CreateIndex(
                name: "IX_NurseNotes_IncomesINCOME_ID",
                table: "NurseNotes",
                column: "IncomesINCOME_ID");

            migrationBuilder.CreateIndex(
                name: "IX_NurseNotes_SpecialitiesSPEC_ID",
                table: "NurseNotes",
                column: "SpecialitiesSPEC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_NurseNotes_STAFF_ID",
                table: "NurseNotes",
                column: "STAFF_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Incomes_PatientsPATIENT_ID",
                table: "Incomes",
                column: "PatientsPATIENT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Incomes_UsersUSR_ID",
                table: "Incomes",
                column: "UsersUSR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PerXGroups_GroupsGRP_ID",
                table: "PerXGroups",
                column: "GroupsGRP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PerXGroups_PermitionsPER_ID",
                table: "PerXGroups",
                column: "PermitionsPER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Signs_NurseNoteNOTE_ID",
                table: "Signs",
                column: "NurseNoteNOTE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_HeadqueartersHEADQ_ID",
                table: "Staffs",
                column: "HeadqueartersHEADQ_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_SpecialitiesSPEC_ID",
                table: "Staffs",
                column: "SpecialitiesSPEC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_UsersUSR_ID",
                table: "Staffs",
                column: "UsersUSR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SuppliesPatients_IncomesINCOME_ID",
                table: "SuppliesPatients",
                column: "IncomesINCOME_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SuppliesPatients_MedicationsMED_ID",
                table: "SuppliesPatients",
                column: "MedicationsMED_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Incomes_Patients_PatientsPATIENT_ID",
                table: "Incomes",
                column: "PatientsPATIENT_ID",
                principalTable: "Patients",
                principalColumn: "PATIENT_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Incomes_Users_UsersUSR_ID",
                table: "Incomes",
                column: "UsersUSR_ID",
                principalTable: "Users",
                principalColumn: "USR_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NurseNotes_Diagnosis_DiagnosisDIAG_ID",
                table: "NurseNotes",
                column: "DiagnosisDIAG_ID",
                principalTable: "Diagnosis",
                principalColumn: "DIAG_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NurseNotes_Incomes_IncomesINCOME_ID",
                table: "NurseNotes",
                column: "IncomesINCOME_ID",
                principalTable: "Incomes",
                principalColumn: "INCOME_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NurseNotes_Specialities_SpecialitiesSPEC_ID",
                table: "NurseNotes",
                column: "SpecialitiesSPEC_ID",
                principalTable: "Specialities",
                principalColumn: "SPEC_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NurseNotes_Staffs_STAFF_ID",
                table: "NurseNotes",
                column: "STAFF_ID",
                principalTable: "Staffs",
                principalColumn: "STAFF_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_TipDocs_TipDocsTIPDOC_ID",
                table: "Patients",
                column: "TipDocsTIPDOC_ID",
                principalTable: "TipDocs",
                principalColumn: "TIPDOC_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Groups_GroupsGRP_ID",
                table: "Users",
                column: "GroupsGRP_ID",
                principalTable: "Groups",
                principalColumn: "GRP_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incomes_Patients_PatientsPATIENT_ID",
                table: "Incomes");

            migrationBuilder.DropForeignKey(
                name: "FK_Incomes_Users_UsersUSR_ID",
                table: "Incomes");

            migrationBuilder.DropForeignKey(
                name: "FK_NurseNotes_Diagnosis_DiagnosisDIAG_ID",
                table: "NurseNotes");

            migrationBuilder.DropForeignKey(
                name: "FK_NurseNotes_Incomes_IncomesINCOME_ID",
                table: "NurseNotes");

            migrationBuilder.DropForeignKey(
                name: "FK_NurseNotes_Specialities_SpecialitiesSPEC_ID",
                table: "NurseNotes");

            migrationBuilder.DropForeignKey(
                name: "FK_NurseNotes_Staffs_STAFF_ID",
                table: "NurseNotes");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_TipDocs_TipDocsTIPDOC_ID",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Groups_GroupsGRP_ID",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Diagnosis");

            migrationBuilder.DropTable(
                name: "PerXGroups");

            migrationBuilder.DropTable(
                name: "Signs");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "SuppliesPatients");

            migrationBuilder.DropTable(
                name: "TipDocs");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Permitions");

            migrationBuilder.DropTable(
                name: "Headquearters");

            migrationBuilder.DropTable(
                name: "Specialities");

            migrationBuilder.DropTable(
                name: "Medications");

            migrationBuilder.DropIndex(
                name: "IX_Users_GroupsGRP_ID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Patients_TipDocsTIPDOC_ID",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_NurseNotes_DiagnosisDIAG_ID",
                table: "NurseNotes");

            migrationBuilder.DropIndex(
                name: "IX_NurseNotes_IncomesINCOME_ID",
                table: "NurseNotes");

            migrationBuilder.DropIndex(
                name: "IX_NurseNotes_SpecialitiesSPEC_ID",
                table: "NurseNotes");

            migrationBuilder.DropIndex(
                name: "IX_NurseNotes_STAFF_ID",
                table: "NurseNotes");

            migrationBuilder.DropIndex(
                name: "IX_Incomes_PatientsPATIENT_ID",
                table: "Incomes");

            migrationBuilder.DropIndex(
                name: "IX_Incomes_UsersUSR_ID",
                table: "Incomes");

            migrationBuilder.DropColumn(
                name: "GroupsGRP_ID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TipDocsTIPDOC_ID",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "DiagnosisDIAG_ID",
                table: "NurseNotes");

            migrationBuilder.DropColumn(
                name: "IncomesINCOME_ID",
                table: "NurseNotes");

            migrationBuilder.DropColumn(
                name: "STAFF_ID",
                table: "NurseNotes");

            migrationBuilder.DropColumn(
                name: "SpecialitiesSPEC_ID",
                table: "NurseNotes");

            migrationBuilder.DropColumn(
                name: "FCHINCOME",
                table: "Incomes");

            migrationBuilder.DropColumn(
                name: "PatientsPATIENT_ID",
                table: "Incomes");

            migrationBuilder.DropColumn(
                name: "UsersUSR_ID",
                table: "Incomes");
        }
    }
}
