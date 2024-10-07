using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NurseNotes.Migrations
{
    /// <inheritdoc />
    public partial class LastUpdateTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NurseNotes_Staffs_STAFF_ID",
                table: "NurseNotes");

            migrationBuilder.DropForeignKey(
                name: "FK_Signs_NurseNotes_NurseNoteNOTE_ID",
                table: "Signs");

            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_Headquearters_HEADQ_ID",
                table: "Staffs");

            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_Specialities_SPEC_ID",
                table: "Staffs");

            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_Users_USR_ID",
                table: "Staffs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Staffs",
                table: "Staffs");

            migrationBuilder.RenameTable(
                name: "Staffs",
                newName: "Staff");

            migrationBuilder.RenameColumn(
                name: "NurseNoteNOTE_ID",
                table: "Signs",
                newName: "NOTE_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Signs_NurseNoteNOTE_ID",
                table: "Signs",
                newName: "IX_Signs_NOTE_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Staffs_USR_ID",
                table: "Staff",
                newName: "IX_Staff_USR_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Staffs_SPEC_ID",
                table: "Staff",
                newName: "IX_Staff_SPEC_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Staffs_HEADQ_ID",
                table: "Staff",
                newName: "IX_Staff_HEADQ_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Staff",
                table: "Staff",
                column: "STAFF_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_NurseNotes_Staff_STAFF_ID",
                table: "NurseNotes",
                column: "STAFF_ID",
                principalTable: "Staff",
                principalColumn: "STAFF_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Signs_NurseNotes_NOTE_ID",
                table: "Signs",
                column: "NOTE_ID",
                principalTable: "NurseNotes",
                principalColumn: "NOTE_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Headquearters_HEADQ_ID",
                table: "Staff",
                column: "HEADQ_ID",
                principalTable: "Headquearters",
                principalColumn: "HEADQ_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Specialities_SPEC_ID",
                table: "Staff",
                column: "SPEC_ID",
                principalTable: "Specialities",
                principalColumn: "SPEC_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Users_USR_ID",
                table: "Staff",
                column: "USR_ID",
                principalTable: "Users",
                principalColumn: "USR_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NurseNotes_Staff_STAFF_ID",
                table: "NurseNotes");

            migrationBuilder.DropForeignKey(
                name: "FK_Signs_NurseNotes_NOTE_ID",
                table: "Signs");

            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Headquearters_HEADQ_ID",
                table: "Staff");

            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Specialities_SPEC_ID",
                table: "Staff");

            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Users_USR_ID",
                table: "Staff");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Staff",
                table: "Staff");

            migrationBuilder.RenameTable(
                name: "Staff",
                newName: "Staffs");

            migrationBuilder.RenameColumn(
                name: "NOTE_ID",
                table: "Signs",
                newName: "NurseNoteNOTE_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Signs_NOTE_ID",
                table: "Signs",
                newName: "IX_Signs_NurseNoteNOTE_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Staff_USR_ID",
                table: "Staffs",
                newName: "IX_Staffs_USR_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Staff_SPEC_ID",
                table: "Staffs",
                newName: "IX_Staffs_SPEC_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Staff_HEADQ_ID",
                table: "Staffs",
                newName: "IX_Staffs_HEADQ_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Staffs",
                table: "Staffs",
                column: "STAFF_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_NurseNotes_Staffs_STAFF_ID",
                table: "NurseNotes",
                column: "STAFF_ID",
                principalTable: "Staffs",
                principalColumn: "STAFF_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Signs_NurseNotes_NurseNoteNOTE_ID",
                table: "Signs",
                column: "NurseNoteNOTE_ID",
                principalTable: "NurseNotes",
                principalColumn: "NOTE_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_Headquearters_HEADQ_ID",
                table: "Staffs",
                column: "HEADQ_ID",
                principalTable: "Headquearters",
                principalColumn: "HEADQ_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_Specialities_SPEC_ID",
                table: "Staffs",
                column: "SPEC_ID",
                principalTable: "Specialities",
                principalColumn: "SPEC_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_Users_USR_ID",
                table: "Staffs",
                column: "USR_ID",
                principalTable: "Users",
                principalColumn: "USR_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
