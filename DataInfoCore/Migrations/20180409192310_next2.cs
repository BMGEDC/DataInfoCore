using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DataInfoCore.Migrations
{
    public partial class next2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Market",
                table: "Wholesaler");

            migrationBuilder.AddColumn<int>(
                name: "MarketID",
                table: "Wholesaler",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contact_WholesalerID",
                table: "Contact",
                column: "WholesalerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Wholesaler_WholesalerID",
                table: "Contact",
                column: "WholesalerID",
                principalTable: "Wholesaler",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Wholesaler_WholesalerID",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Contact_WholesalerID",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "MarketID",
                table: "Wholesaler");

            migrationBuilder.AddColumn<string>(
                name: "Market",
                table: "Wholesaler",
                maxLength: 5,
                nullable: true);
        }
    }
}
