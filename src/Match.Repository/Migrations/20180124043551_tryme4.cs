using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Match.Repository.Migrations
{
    public partial class tryme4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Party",
                newName: "MiddleName");

            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "Party",
                newName: "OtherName");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Party",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AccountName",
                table: "BankAccount",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Party");

            migrationBuilder.DropColumn(
                name: "AccountName",
                table: "BankAccount");

            migrationBuilder.RenameColumn(
                name: "MiddleName",
                table: "Party",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "OtherName",
                table: "Party",
                newName: "CompanyName");
        }
    }
}
