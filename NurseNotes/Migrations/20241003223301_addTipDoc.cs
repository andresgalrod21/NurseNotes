using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NurseNotes.Migrations
{
    /// <inheritdoc />
    public partial class addTipDoc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_tipDoc_TipDocsTIPDOC_ID",
                table: "Patient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tipDoc",
                table: "tipDoc");

            migrationBuilder.RenameTable(
                name: "tipDoc",
                newName: "TipDoc");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipDoc",
                table: "TipDoc",
                column: "TIPDOC_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_TipDoc_TipDocsTIPDOC_ID",
                table: "Patient",
                column: "TipDocsTIPDOC_ID",
                principalTable: "TipDoc",
                principalColumn: "TIPDOC_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_TipDoc_TipDocsTIPDOC_ID",
                table: "Patient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipDoc",
                table: "TipDoc");

            migrationBuilder.RenameTable(
                name: "TipDoc",
                newName: "tipDoc");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tipDoc",
                table: "tipDoc",
                column: "TIPDOC_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_tipDoc_TipDocsTIPDOC_ID",
                table: "Patient",
                column: "TipDocsTIPDOC_ID",
                principalTable: "tipDoc",
                principalColumn: "TIPDOC_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
