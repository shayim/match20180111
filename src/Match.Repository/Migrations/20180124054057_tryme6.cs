using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Match.Repository.Migrations
{
    public partial class tryme6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientSalesPerson_Employee_SalesPersonId",
                table: "ClientSalesPerson");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Department_DepartmentId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Party_Id",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_EmploymentContract_Employee_EmployeeId",
                table: "EmploymentContract");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_DepartmentId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EmployeeNum",
                table: "Employee");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "SalesPersons");

            migrationBuilder.AlterColumn<int>(
                name: "SalesPersonType",
                table: "SalesPersons",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesPersons",
                table: "SalesPersons",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false),
                    EmployeeNum = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Party_Id",
                        column: x => x.Id,
                        principalTable: "Party",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartmentId",
                table: "Employee",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientSalesPerson_SalesPersons_SalesPersonId",
                table: "ClientSalesPerson",
                column: "SalesPersonId",
                principalTable: "SalesPersons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmploymentContract_Employee_EmployeeId",
                table: "EmploymentContract",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesPersons_Employee_Id",
                table: "SalesPersons",
                column: "Id",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientSalesPerson_SalesPersons_SalesPersonId",
                table: "ClientSalesPerson");

            migrationBuilder.DropForeignKey(
                name: "FK_EmploymentContract_Employee_EmployeeId",
                table: "EmploymentContract");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesPersons_Employee_Id",
                table: "SalesPersons");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesPersons",
                table: "SalesPersons");

            migrationBuilder.RenameTable(
                name: "SalesPersons",
                newName: "Employee");

            migrationBuilder.AlterColumn<int>(
                name: "SalesPersonType",
                table: "Employee",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Employee",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeNum",
                table: "Employee",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartmentId",
                table: "Employee",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientSalesPerson_Employee_SalesPersonId",
                table: "ClientSalesPerson",
                column: "SalesPersonId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Department_DepartmentId",
                table: "Employee",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Party_Id",
                table: "Employee",
                column: "Id",
                principalTable: "Party",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmploymentContract_Employee_EmployeeId",
                table: "EmploymentContract",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
