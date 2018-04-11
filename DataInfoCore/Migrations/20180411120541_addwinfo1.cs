using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DataInfoCore.Migrations
{
    public partial class addwinfo1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EMail",
                table: "Contact",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contact_EMail",
                table: "Contact",
                column: "EMail",
                unique: true,
                filter: "[EMail] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Contact_EMail",
                table: "Contact");

            migrationBuilder.AlterColumn<string>(
                name: "EMail",
                table: "Contact",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
