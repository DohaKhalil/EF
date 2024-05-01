using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkAssignment.Migrations
{
    public partial class AirCraft : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AirCraft_Routes_AirCraft_AirCraftId",
                table: "AirCraft_Routes");

            migrationBuilder.DropForeignKey(
                name: "FK_AirCraft_Routes_Routes_RouteId",
                table: "AirCraft_Routes");

            migrationBuilder.AlterColumn<int>(
                name: "RouteId",
                table: "AirCraft_Routes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AirCraftId",
                table: "AirCraft_Routes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AirCraft_Routes_AirCraft_AirCraftId",
                table: "AirCraft_Routes",
                column: "AirCraftId",
                principalTable: "AirCraft",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AirCraft_Routes_Routes_RouteId",
                table: "AirCraft_Routes",
                column: "RouteId",
                principalTable: "Routes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AirCraft_Routes_AirCraft_AirCraftId",
                table: "AirCraft_Routes");

            migrationBuilder.DropForeignKey(
                name: "FK_AirCraft_Routes_Routes_RouteId",
                table: "AirCraft_Routes");

            migrationBuilder.AlterColumn<int>(
                name: "RouteId",
                table: "AirCraft_Routes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AirCraftId",
                table: "AirCraft_Routes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_AirCraft_Routes_AirCraft_AirCraftId",
                table: "AirCraft_Routes",
                column: "AirCraftId",
                principalTable: "AirCraft",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AirCraft_Routes_Routes_RouteId",
                table: "AirCraft_Routes",
                column: "RouteId",
                principalTable: "Routes",
                principalColumn: "Id");
        }
    }
}
