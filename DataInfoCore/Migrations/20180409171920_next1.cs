using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DataInfoCore.Migrations
{
    public partial class next1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Market_Config_ConfigID",
                table: "Market");

            migrationBuilder.DropForeignKey(
                name: "FK_Wholesaler_Config_ConfigID",
                table: "Wholesaler");

            migrationBuilder.DropIndex(
                name: "IX_Wholesaler_ConfigID",
                table: "Wholesaler");

            migrationBuilder.DropIndex(
                name: "IX_Market_ConfigID",
                table: "Market");

            migrationBuilder.DropColumn(
                name: "ConfigID",
                table: "Wholesaler");

            migrationBuilder.DropColumn(
                name: "ConfigID",
                table: "Market");

            migrationBuilder.AddColumn<int>(
                name: "ConfigID",
                table: "Processlog",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfigID",
                table: "Processlog");

            migrationBuilder.AddColumn<int>(
                name: "ConfigID",
                table: "Wholesaler",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConfigID",
                table: "Market",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Wholesaler_ConfigID",
                table: "Wholesaler",
                column: "ConfigID");

            migrationBuilder.CreateIndex(
                name: "IX_Market_ConfigID",
                table: "Market",
                column: "ConfigID");

            migrationBuilder.AddForeignKey(
                name: "FK_Market_Config_ConfigID",
                table: "Market",
                column: "ConfigID",
                principalTable: "Config",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wholesaler_Config_ConfigID",
                table: "Wholesaler",
                column: "ConfigID",
                principalTable: "Config",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
