using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Relationship___Assignment_3.Migrations
{
    /// <inheritdoc />
    public partial class IntialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airline",
                columns: table => new
                {
                    AirLine_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AirlineName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Contact_person = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airline", x => x.AirLine_Id);
                });

            migrationBuilder.CreateTable(
                name: "Route",
                columns: table => new
                {
                    RouteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Classification = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Distance = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Orgin = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Distination = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Route", x => x.RouteId);
                });

            migrationBuilder.CreateTable(
                name: "Aircrafts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "10, 10"),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    AirlineID = table.Column<int>(type: "int", nullable: false),
                    MajorPilot = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AssistantPilot = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Host1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Host2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aircrafts", x => x.Id);
                    table.CheckConstraint("CK_Aircraft_Capacity", "[Capacity] > 0 AND [Capacity] <= 250");
                    table.CheckConstraint("CK_Crews_AtLeastOneMember", "[MajorPilot] IS NOT NULL OR [AssistantPilot] IS NOT NULL OR [Host1] IS NOT NULL OR [Host2] IS NOT NULL");
                    table.ForeignKey(
                        name: "FK_Aircrafts_Airline_AirlineID",
                        column: x => x.AirlineID,
                        principalTable: "Airline",
                        principalColumn: "AirLine_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AirLinePhones",
                columns: table => new
                {
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    AirlineID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirLinePhones", x => new { x.AirlineID, x.PhoneNumber });
                    table.CheckConstraint("CK_AirLinePhones_Format", "LEN([PhoneNumber]) <=11 AND [PhoneNumber] LIKE '01%'");
                    table.ForeignKey(
                        name: "FK_AirLinePhones_Airline_AirlineID",
                        column: x => x.AirlineID,
                        principalTable: "Airline",
                        principalColumn: "AirLine_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    EmpAddress = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Position = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    BirthYear = table.Column<int>(type: "int", nullable: false),
                    BirthMonth = table.Column<int>(type: "int", nullable: false),
                    BirthDay = table.Column<int>(type: "int", nullable: false),
                    AirlineID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employee_Airline_AirlineID",
                        column: x => x.AirlineID,
                        principalTable: "Airline",
                        principalColumn: "AirLine_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    Transaction_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionDescription = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    TransactionAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AirlineID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.Transaction_Id);
                    table.ForeignKey(
                        name: "FK_Transaction_Airline_AirlineID",
                        column: x => x.AirlineID,
                        principalTable: "Airline",
                        principalColumn: "AirLine_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AircraftRoute",
                columns: table => new
                {
                    Aircraft_Id = table.Column<int>(type: "int", nullable: false),
                    RouteId = table.Column<int>(type: "int", nullable: false),
                    NumberOfPassenger = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Departure = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Arrival = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    Duration = table.Column<decimal>(type: "decimal(9,2)", precision: 9, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AircraftRoute", x => new { x.Aircraft_Id, x.RouteId });
                    table.CheckConstraint("CK_AircraftRoutes_Duration_Positive", "[Duration] > 0");
                    table.CheckConstraint("CK_AircraftRoutes_NumPassengers", "[NumberOfPassenger] >= 0 AND [NumberOfPassenger] <= 250");
                    table.ForeignKey(
                        name: "FK_AircraftRoute_Aircrafts_Aircraft_Id",
                        column: x => x.Aircraft_Id,
                        principalTable: "Aircrafts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AircraftRoute_Route_RouteId",
                        column: x => x.RouteId,
                        principalTable: "Route",
                        principalColumn: "RouteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeQualifications",
                columns: table => new
                {
                    EmpId = table.Column<int>(type: "int", nullable: false),
                    Qualification = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeQualifications", x => new { x.Qualification, x.EmpId });
                    table.ForeignKey(
                        name: "FK_EmployeeQualifications_Employee_EmpId",
                        column: x => x.EmpId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AircraftRoute_RouteId",
                table: "AircraftRoute",
                column: "RouteId");

            migrationBuilder.CreateIndex(
                name: "IX_Aircrafts_AirlineID",
                table: "Aircrafts",
                column: "AirlineID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_AirlineID",
                table: "Employee",
                column: "AirlineID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeQualifications_EmpId",
                table: "EmployeeQualifications",
                column: "EmpId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_AirlineID",
                table: "Transaction",
                column: "AirlineID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AircraftRoute");

            migrationBuilder.DropTable(
                name: "AirLinePhones");

            migrationBuilder.DropTable(
                name: "EmployeeQualifications");

            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "Aircrafts");

            migrationBuilder.DropTable(
                name: "Route");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Airline");
        }
    }
}
