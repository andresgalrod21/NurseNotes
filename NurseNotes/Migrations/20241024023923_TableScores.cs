using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NurseNotes.Migrations
{
    /// <inheritdoc />
    public partial class TableScores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PerXGroups_Groups_GRP_ID",
                table: "PerXGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_PerXGroups_Permitions_PER_ID",
                table: "PerXGroups");

            migrationBuilder.CreateTable(
                name: "Scores",
                columns: table => new
                {
                    SCORE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PLAYERNAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AGE = table.Column<int>(type: "int", nullable: false),
                    GENDER = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SCORE = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scores", x => x.SCORE_ID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_PerXGroups_Groups_GRP_ID",
                table: "PerXGroups",
                column: "GRP_ID",
                principalTable: "Groups",
                principalColumn: "GRP_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PerXGroups_Permitions_PER_ID",
                table: "PerXGroups",
                column: "PER_ID",
                principalTable: "Permitions",
                principalColumn: "PER_ID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PerXGroups_Groups_GRP_ID",
                table: "PerXGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_PerXGroups_Permitions_PER_ID",
                table: "PerXGroups");

            migrationBuilder.DropTable(
                name: "Scores");

            migrationBuilder.AddForeignKey(
                name: "FK_PerXGroups_Groups_GRP_ID",
                table: "PerXGroups",
                column: "GRP_ID",
                principalTable: "Groups",
                principalColumn: "GRP_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PerXGroups_Permitions_PER_ID",
                table: "PerXGroups",
                column: "PER_ID",
                principalTable: "Permitions",
                principalColumn: "PER_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
