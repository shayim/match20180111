using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Match.Repository.Migrations
{
    public partial class tryme3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EmploymentContract",
                table: "EmploymentContract");

            migrationBuilder.DropIndex(
                name: "IX_EmploymentContract_EmployeeId",
                table: "EmploymentContract");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EmploymentContract");

            migrationBuilder.AddColumn<DateTime>(
                name: "IssueDate",
                table: "IdentityDocument",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "IssueDate",
                table: "EmploymentContract",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmploymentContract",
                table: "EmploymentContract",
                columns: new[] { "EmployeeId", "Num" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EmploymentContract",
                table: "EmploymentContract");

            migrationBuilder.DropColumn(
                name: "IssueDate",
                table: "IdentityDocument");

            migrationBuilder.DropColumn(
                name: "IssueDate",
                table: "EmploymentContract");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "EmploymentContract",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmploymentContract",
                table: "EmploymentContract",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_EmploymentContract_EmployeeId",
                table: "EmploymentContract",
                column: "EmployeeId");
        }
    }
}
