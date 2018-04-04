using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DataInfoCore.Migrations
{
    public partial class addroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookContact1ID",
                table: "Wholesaler");

            migrationBuilder.DropColumn(
                name: "BookContactID",
                table: "Wholesaler");

            migrationBuilder.DropColumn(
                name: "BookFileID",
                table: "Wholesaler");

            migrationBuilder.DropColumn(
                name: "CustFileID",
                table: "Wholesaler");

            migrationBuilder.DropColumn(
                name: "ITContactID",
                table: "Wholesaler");

            migrationBuilder.DropColumn(
                name: "InvFileID",
                table: "Wholesaler");

            migrationBuilder.DropColumn(
                name: "OrderContactID",
                table: "Wholesaler");

            migrationBuilder.DropColumn(
                name: "WebContact1ID",
                table: "Wholesaler");

            migrationBuilder.DropColumn(
                name: "WebContactID",
                table: "Wholesaler");

            migrationBuilder.AddColumn<string>(
                name: "Eorders",
                table: "Market",
                maxLength: 1,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ContactRole",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContactId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    WholesalerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactRole", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleDescription = table.Column<string>(maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactRole");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropColumn(
                name: "Eorders",
                table: "Market");

            migrationBuilder.AddColumn<int>(
                name: "BookContact1ID",
                table: "Wholesaler",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BookContactID",
                table: "Wholesaler",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BookFileID",
                table: "Wholesaler",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustFileID",
                table: "Wholesaler",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ITContactID",
                table: "Wholesaler",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InvFileID",
                table: "Wholesaler",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderContactID",
                table: "Wholesaler",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WebContact1ID",
                table: "Wholesaler",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WebContactID",
                table: "Wholesaler",
                nullable: false,
                defaultValue: 0);
        }
    }
}
