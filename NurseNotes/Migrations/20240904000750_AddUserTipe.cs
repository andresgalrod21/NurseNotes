using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NurseNotes.Migrations
{
    /// <inheritdoc />
    public partial class AddUserTipe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserTIpeId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "UsersTIpe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersTIpe", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserTIpeId",
                table: "Users",
                column: "UserTIpeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UsersTIpe_UserTIpeId",
                table: "Users",
                column: "UserTIpeId",
                principalTable: "UsersTIpe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UsersTIpe_UserTIpeId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "UsersTIpe");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserTIpeId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserTIpeId",
                table: "Users");
        }
    }
}
