using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NurseNotes.Migrations
{
    /// <inheritdoc />
    public partial class addTipDocs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_TipDocs_TipDocsTIPDOC_ID",
                table: "Patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipDocs",
                table: "TipDocs");

            migrationBuilder.RenameTable(
                name: "TipDocs",
                newName: "tipDocs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tipDocs",
                table: "tipDocs",
                column: "TIPDOC_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_tipDocs_TipDocsTIPDOC_ID",
                table: "Patients",
                column: "TipDocsTIPDOC_ID",
                principalTable: "tipDocs",
                principalColumn: "TIPDOC_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_tipDocs_TipDocsTIPDOC_ID",
                table: "Patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tipDocs",
                table: "tipDocs");

            migrationBuilder.RenameTable(
                name: "tipDocs",
                newName: "TipDocs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipDocs",
                table: "TipDocs",
                column: "TIPDOC_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_TipDocs_TipDocsTIPDOC_ID",
                table: "Patients",
                column: "TipDocsTIPDOC_ID",
                principalTable: "TipDocs",
                principalColumn: "TIPDOC_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
