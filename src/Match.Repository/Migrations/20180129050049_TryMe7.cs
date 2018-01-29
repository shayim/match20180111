using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Match.Repository.Migrations
{
    public partial class TryMe7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Party_Id",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientSalesPerson_Clients_ClientId",
                table: "ClientSalesPerson");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientSalesPerson_SalesPersons_SalesPersonId",
                table: "ClientSalesPerson");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesPersons_Employee_Id",
                table: "SalesPersons");

            migrationBuilder.DropForeignKey(
                name: "FK_SocialMediaAccount_SocialMediaType_SocialMediaTypeId",
                table: "SocialMediaAccount");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesPersons",
                table: "SalesPersons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clients",
                table: "Clients");

            migrationBuilder.RenameTable(
                name: "SalesPersons",
                newName: "SalesPerson");

            migrationBuilder.RenameTable(
                name: "Clients",
                newName: "Client");

            migrationBuilder.RenameColumn(
                name: "SocialMediaTypeId",
                table: "SocialMediaAccount",
                newName: "TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_SocialMediaAccount_SocialMediaTypeId",
                table: "SocialMediaAccount",
                newName: "IX_SocialMediaAccount_TypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesPerson",
                table: "SalesPerson",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Client",
                table: "Client",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Party_Id",
                table: "Client",
                column: "Id",
                principalTable: "Party",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientSalesPerson_Client_ClientId",
                table: "ClientSalesPerson",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientSalesPerson_SalesPerson_SalesPersonId",
                table: "ClientSalesPerson",
                column: "SalesPersonId",
                principalTable: "SalesPerson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesPerson_Employee_Id",
                table: "SalesPerson",
                column: "Id",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SocialMediaAccount_SocialMediaType_TypeId",
                table: "SocialMediaAccount",
                column: "TypeId",
                principalTable: "SocialMediaType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Party_Id",
                table: "Client");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientSalesPerson_Client_ClientId",
                table: "ClientSalesPerson");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientSalesPerson_SalesPerson_SalesPersonId",
                table: "ClientSalesPerson");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesPerson_Employee_Id",
                table: "SalesPerson");

            migrationBuilder.DropForeignKey(
                name: "FK_SocialMediaAccount_SocialMediaType_TypeId",
                table: "SocialMediaAccount");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesPerson",
                table: "SalesPerson");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Client",
                table: "Client");

            migrationBuilder.RenameTable(
                name: "SalesPerson",
                newName: "SalesPersons");

            migrationBuilder.RenameTable(
                name: "Client",
                newName: "Clients");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "SocialMediaAccount",
                newName: "SocialMediaTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_SocialMediaAccount_TypeId",
                table: "SocialMediaAccount",
                newName: "IX_SocialMediaAccount_SocialMediaTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesPersons",
                table: "SalesPersons",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clients",
                table: "Clients",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Party_Id",
                table: "Clients",
                column: "Id",
                principalTable: "Party",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientSalesPerson_Clients_ClientId",
                table: "ClientSalesPerson",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientSalesPerson_SalesPersons_SalesPersonId",
                table: "ClientSalesPerson",
                column: "SalesPersonId",
                principalTable: "SalesPersons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesPersons_Employee_Id",
                table: "SalesPersons",
                column: "Id",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SocialMediaAccount_SocialMediaType_SocialMediaTypeId",
                table: "SocialMediaAccount",
                column: "SocialMediaTypeId",
                principalTable: "SocialMediaType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
