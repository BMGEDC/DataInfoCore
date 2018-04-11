using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DataInfoCore.Migrations
{
    public partial class addwinfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Price_Zone",
                table: "Wholesaler",
                maxLength: 3,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "bm_id",
                table: "Wholesaler",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "org_id",
                table: "Wholesaler",
                maxLength: 10,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price_Zone",
                table: "Wholesaler");

            migrationBuilder.DropColumn(
                name: "bm_id",
                table: "Wholesaler");

            migrationBuilder.DropColumn(
                name: "org_id",
                table: "Wholesaler");
        }
    }
}
