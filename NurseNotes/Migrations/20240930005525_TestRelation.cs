using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NurseNotes.Migrations
{
    /// <inheritdoc />
    public partial class TestRelation : Migration
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

            migrationBuilder.CreateIndex(
                name: "IX_UsersLogs_USR_ID",
                table: "UsersLogs",
                column: "USR_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersLogs");

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
