using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DataInfoCore.Migrations
{
    public partial class addwinfo2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WholesalerInfo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Desc = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(maxLength: 30, nullable: true),
                    MainPhone = table.Column<string>(maxLength: 30, nullable: true),
                    WholesalerID = table.Column<int>(nullable: false),
                    address1 = table.Column<string>(maxLength: 30, nullable: true),
                    address2 = table.Column<string>(maxLength: 30, nullable: true),
                    address3 = table.Column<string>(maxLength: 30, nullable: true),
                    allowedits = table.Column<string>(maxLength: 2, nullable: true),
                    avail_mess = table.Column<string>(maxLength: 250, nullable: true),
                    city = table.Column<string>(maxLength: 30, nullable: true),
                    cutoff_tm = table.Column<string>(maxLength: 10, nullable: true),
                    dba = table.Column<string>(nullable: true),
                    downstart = table.Column<DateTime>(nullable: false),
                    facetsname = table.Column<string>(maxLength: 150, nullable: true),
                    faxcheck = table.Column<string>(maxLength: 1, nullable: true),
                    freeshpamt = table.Column<float>(nullable: false),
                    itemcnt = table.Column<int>(nullable: false),
                    level3 = table.Column<string>(maxLength: 1, nullable: true),
                    min_case = table.Column<float>(nullable: false),
                    min_type = table.Column<string>(maxLength: 1, nullable: true),
                    newratcnt = table.Column<float>(nullable: false),
                    nostockmsg = table.Column<string>(nullable: true),
                    novirtual = table.Column<string>(maxLength: 1, nullable: true),
                    policies = table.Column<string>(nullable: true),
                    rejectord = table.Column<string>(maxLength: 1, nullable: true),
                    ship_fee = table.Column<float>(nullable: false),
                    show_blind = table.Column<string>(maxLength: 1, nullable: true),
                    skipfaxord = table.Column<string>(maxLength: 1, nullable: true),
                    smancnt = table.Column<int>(nullable: false),
                    split_fee = table.Column<float>(nullable: false),
                    sqlfailno = table.Column<int>(nullable: false),
                    state = table.Column<string>(maxLength: 2, nullable: true),
                    statusrpt = table.Column<string>(maxLength: 1, nullable: true),
                    strepstamp = table.Column<DateTime>(nullable: false),
                    tstamp = table.Column<DateTime>(nullable: false),
                    usewhdesc = table.Column<string>(maxLength: 50, nullable: true),
                    webname = table.Column<string>(maxLength: 150, nullable: true),
                    zip = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WholesalerInfo", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WholesalerInfo_Wholesaler_WholesalerID",
                        column: x => x.WholesalerID,
                        principalTable: "Wholesaler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WholesalerInfo_WholesalerID",
                table: "WholesalerInfo",
                column: "WholesalerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WholesalerInfo");
        }
    }
}
