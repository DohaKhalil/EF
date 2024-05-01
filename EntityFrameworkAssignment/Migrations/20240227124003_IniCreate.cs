using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkAssignment.Migrations
{
    public partial class IniCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AirLines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Count_Person = table.Column<int>(type: "int", nullable: false),
                    AirCraftsId = table.Column<int>(type: "int", nullable: false),
                    TransactionId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirLines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Distnace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Distanction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Orgine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Classfication = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AirCraft",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capsity = table.Column<int>(type: "int", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Maj_Pailot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Assistant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Host_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Host_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AirLineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirCraft", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AirCraft_AirLines_AirLineId",
                        column: x => x.AirLineId,
                        principalTable: "AirLines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AirLine_Phones",
                columns: table => new
                {
                    AirLineId = table.Column<int>(type: "int", nullable: false),
                    phone = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirLine_Phones", x => new { x.phone, x.AirLineId });
                    table.ForeignKey(
                        name: "FK_AirLine_Phones_AirLines_AirLineId",
                        column: x => x.AirLineId,
                        principalTable: "AirLines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    postion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BD_Year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BD_Month = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BD_Day = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AirLineId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_AirLines_AirLineId",
                        column: x => x.AirLineId,
                        principalTable: "AirLines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Discription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    AirLineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_AirLines_AirLineId",
                        column: x => x.AirLineId,
                        principalTable: "AirLines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AirCraft_Routes",
                columns: table => new
                {
                    ACRId = table.Column<int>(type: "int", nullable: false),
                    RoutId = table.Column<int>(type: "int", nullable: false),
                    Departure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Num_Of_Pass = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Arrival = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AirCraftId = table.Column<int>(type: "int", nullable: true),
                    RouteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirCraft_Routes", x => new { x.ACRId, x.RoutId });
                    table.ForeignKey(
                        name: "FK_AirCraft_Routes_AirCraft_AirCraftId",
                        column: x => x.AirCraftId,
                        principalTable: "AirCraft",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AirCraft_Routes_Routes_RouteId",
                        column: x => x.RouteId,
                        principalTable: "Routes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Emp_Cualifications",
                columns: table => new
                {
                    Qulification = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmployeesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emp_Cualifications", x => new { x.EmployeesId, x.Qulification });
                    table.ForeignKey(
                        name: "FK_Emp_Cualifications_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AirCraft_AirLineId",
                table: "AirCraft",
                column: "AirLineId");

            migrationBuilder.CreateIndex(
                name: "IX_AirCraft_Routes_AirCraftId",
                table: "AirCraft_Routes",
                column: "AirCraftId");

            migrationBuilder.CreateIndex(
                name: "IX_AirCraft_Routes_RouteId",
                table: "AirCraft_Routes",
                column: "RouteId");

            migrationBuilder.CreateIndex(
                name: "IX_AirLine_Phones_AirLineId",
                table: "AirLine_Phones",
                column: "AirLineId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_AirLineId",
                table: "Employees",
                column: "AirLineId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_AirLineId",
                table: "Transactions",
                column: "AirLineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AirCraft_Routes");

            migrationBuilder.DropTable(
                name: "AirLine_Phones");

            migrationBuilder.DropTable(
                name: "Emp_Cualifications");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "AirCraft");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "AirLines");
        }
    }
}
