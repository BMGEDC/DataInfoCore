using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DataInfoCore.Migrations
{
    public partial class newidwhole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Wholesaler_MarketID",
                table: "Wholesaler",
                column: "MarketID");

            migrationBuilder.CreateIndex(
                name: "IX_Config_MarketID",
                table: "Config",
                column: "MarketID");

            migrationBuilder.CreateIndex(
                name: "IX_Config_WholesalerID",
                table: "Config",
                column: "WholesalerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Config_Market_MarketID",
                table: "Config",
                column: "MarketID",
                principalTable: "Market",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);


            migrationBuilder.AddForeignKey(
                name: "FK_Wholesaler_Market_MarketID",
                table: "Wholesaler",
                column: "MarketID",
                principalTable: "Market",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Config_Market_MarketID",
                table: "Config");

           

            migrationBuilder.DropForeignKey(
                name: "FK_Wholesaler_Market_MarketID",
                table: "Wholesaler");

            migrationBuilder.DropIndex(
                name: "IX_Wholesaler_MarketID",
                table: "Wholesaler");

            migrationBuilder.DropIndex(
                name: "IX_Config_MarketID",
                table: "Config");

            migrationBuilder.DropIndex(
                name: "IX_Config_WholesalerID",
                table: "Config");
        }
    }
}
