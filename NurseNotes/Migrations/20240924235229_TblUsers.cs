using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NurseNotes.Migrations
{
    /// <inheritdoc />
    public partial class TblUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UsersTIpe_UserTIpeId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "UsersTIpe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserTIpeId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "NAME");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Users",
                newName: "USRPSW");

            migrationBuilder.RenameColumn(
                name: "UserTIpeId",
                table: "Users",
                newName: "NUMDOC");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "USR");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Users",
                newName: "TIPDOC");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "GRP_ID");

            migrationBuilder.AlterColumn<int>(
                name: "GRP_ID",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "USR_ID",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "FCHCREATION",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LASTNAME",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "USR_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "USR_ID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FCHCREATION",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LASTNAME",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "NAME",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "USRPSW",
                table: "Users",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "USR",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "TIPDOC",
                table: "Users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "NUMDOC",
                table: "Users",
                newName: "UserTIpeId");

            migrationBuilder.RenameColumn(
                name: "GRP_ID",
                table: "Users",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

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
    }
}
