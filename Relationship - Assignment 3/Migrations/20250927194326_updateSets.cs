using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Relationship___Assignment_3.Migrations
{
    /// <inheritdoc />
    public partial class updateSets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AircraftRoute_Route_RouteId",
                table: "AircraftRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_Aircrafts_Airline_AirlineID",
                table: "Aircrafts");

            migrationBuilder.DropForeignKey(
                name: "FK_AirLinePhones_Airline_AirlineID",
                table: "AirLinePhones");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Airline_AirlineID",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeQualifications_Employee_EmpId",
                table: "EmployeeQualifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Airline_AirlineID",
                table: "Transaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Route",
                table: "Route");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Airline",
                table: "Airline");

            migrationBuilder.RenameTable(
                name: "Transaction",
                newName: "Transactions");

            migrationBuilder.RenameTable(
                name: "Route",
                newName: "Routes");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.RenameTable(
                name: "Airline",
                newName: "Airlines");

            migrationBuilder.RenameIndex(
                name: "IX_Transaction_AirlineID",
                table: "Transactions",
                newName: "IX_Transactions_AirlineID");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_AirlineID",
                table: "Employees",
                newName: "IX_Employees_AirlineID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions",
                column: "Transaction_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Routes",
                table: "Routes",
                column: "RouteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Airlines",
                table: "Airlines",
                column: "AirLine_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AircraftRoute_Routes_RouteId",
                table: "AircraftRoute",
                column: "RouteId",
                principalTable: "Routes",
                principalColumn: "RouteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Aircrafts_Airlines_AirlineID",
                table: "Aircrafts",
                column: "AirlineID",
                principalTable: "Airlines",
                principalColumn: "AirLine_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AirLinePhones_Airlines_AirlineID",
                table: "AirLinePhones",
                column: "AirlineID",
                principalTable: "Airlines",
                principalColumn: "AirLine_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeQualifications_Employees_EmpId",
                table: "EmployeeQualifications",
                column: "EmpId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Airlines_AirlineID",
                table: "Employees",
                column: "AirlineID",
                principalTable: "Airlines",
                principalColumn: "AirLine_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Airlines_AirlineID",
                table: "Transactions",
                column: "AirlineID",
                principalTable: "Airlines",
                principalColumn: "AirLine_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AircraftRoute_Routes_RouteId",
                table: "AircraftRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_Aircrafts_Airlines_AirlineID",
                table: "Aircrafts");

            migrationBuilder.DropForeignKey(
                name: "FK_AirLinePhones_Airlines_AirlineID",
                table: "AirLinePhones");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeQualifications_Employees_EmpId",
                table: "EmployeeQualifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Airlines_AirlineID",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Airlines_AirlineID",
                table: "Transactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Routes",
                table: "Routes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Airlines",
                table: "Airlines");

            migrationBuilder.RenameTable(
                name: "Transactions",
                newName: "Transaction");

            migrationBuilder.RenameTable(
                name: "Routes",
                newName: "Route");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

            migrationBuilder.RenameTable(
                name: "Airlines",
                newName: "Airline");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_AirlineID",
                table: "Transaction",
                newName: "IX_Transaction_AirlineID");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_AirlineID",
                table: "Employee",
                newName: "IX_Employee_AirlineID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction",
                column: "Transaction_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Route",
                table: "Route",
                column: "RouteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Airline",
                table: "Airline",
                column: "AirLine_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AircraftRoute_Route_RouteId",
                table: "AircraftRoute",
                column: "RouteId",
                principalTable: "Route",
                principalColumn: "RouteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Aircrafts_Airline_AirlineID",
                table: "Aircrafts",
                column: "AirlineID",
                principalTable: "Airline",
                principalColumn: "AirLine_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AirLinePhones_Airline_AirlineID",
                table: "AirLinePhones",
                column: "AirlineID",
                principalTable: "Airline",
                principalColumn: "AirLine_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Airline_AirlineID",
                table: "Employee",
                column: "AirlineID",
                principalTable: "Airline",
                principalColumn: "AirLine_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeQualifications_Employee_EmpId",
                table: "EmployeeQualifications",
                column: "EmpId",
                principalTable: "Employee",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Airline_AirlineID",
                table: "Transaction",
                column: "AirlineID",
                principalTable: "Airline",
                principalColumn: "AirLine_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
