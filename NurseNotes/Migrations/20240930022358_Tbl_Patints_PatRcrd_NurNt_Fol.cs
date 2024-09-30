using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NurseNotes.Migrations
{
    /// <inheritdoc />
    public partial class Tbl_Patints_PatRcrd_NurNt_Fol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GRP_ID",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "Incomes",
                columns: table => new
                {
                    INCOME_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incomes", x => x.INCOME_ID);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PATIENT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LASTNAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NUMDOC = table.Column<int>(type: "int", nullable: false),
                    AGE = table.Column<int>(type: "int", nullable: false),
                    NUMCONTACT = table.Column<int>(type: "int", nullable: false),
                    MAIL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PATIENT_ID);
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
                    IncomesINCOME_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientRecords", x => x.PATR_ID);
                    table.ForeignKey(
                        name: "FK_PatientRecords_Incomes_IncomesINCOME_ID",
                        column: x => x.IncomesINCOME_ID,
                        principalTable: "Incomes",
                        principalColumn: "INCOME_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NurseNotes",
                columns: table => new
                {
                    NOTE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientsPATIENT_ID = table.Column<int>(type: "int", nullable: false),
                    REASONCONS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsersUSR_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NurseNotes", x => x.NOTE_ID);
                    table.ForeignKey(
                        name: "FK_NurseNotes_Patients_PatientsPATIENT_ID",
                        column: x => x.PatientsPATIENT_ID,
                        principalTable: "Patients",
                        principalColumn: "PATIENT_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NurseNotes_Users_UsersUSR_ID",
                        column: x => x.UsersUSR_ID,
                        principalTable: "Users",
                        principalColumn: "USR_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Folios",
                columns: table => new
                {
                    FOLIO_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncomesINCOME_ID = table.Column<int>(type: "int", nullable: false),
                    NurseNoteNOTE_ID = table.Column<int>(type: "int", nullable: false),
                    UsersUSR_ID = table.Column<int>(type: "int", nullable: false),
                    EVOLUTION = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Folios", x => x.FOLIO_ID);
                    table.ForeignKey(
                        name: "FK_Folios_Incomes_IncomesINCOME_ID",
                        column: x => x.IncomesINCOME_ID,
                        principalTable: "Incomes",
                        principalColumn: "INCOME_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Folios_NurseNotes_NurseNoteNOTE_ID",
                        column: x => x.NurseNoteNOTE_ID,
                        principalTable: "NurseNotes",
                        principalColumn: "NOTE_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Folios_Users_UsersUSR_ID",
                        column: x => x.UsersUSR_ID,
                        principalTable: "Users",
                        principalColumn: "USR_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Folios_IncomesINCOME_ID",
                table: "Folios",
                column: "IncomesINCOME_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Folios_NurseNoteNOTE_ID",
                table: "Folios",
                column: "NurseNoteNOTE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Folios_UsersUSR_ID",
                table: "Folios",
                column: "UsersUSR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_NurseNotes_PatientsPATIENT_ID",
                table: "NurseNotes",
                column: "PatientsPATIENT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_NurseNotes_UsersUSR_ID",
                table: "NurseNotes",
                column: "UsersUSR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecords_IncomesINCOME_ID",
                table: "PatientRecords",
                column: "IncomesINCOME_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Folios");

            migrationBuilder.DropTable(
                name: "PatientRecords");

            migrationBuilder.DropTable(
                name: "NurseNotes");

            migrationBuilder.DropTable(
                name: "Incomes");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.AddColumn<int>(
                name: "GRP_ID",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
