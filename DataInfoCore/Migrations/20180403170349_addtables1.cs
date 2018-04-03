using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DataInfoCore.Migrations
{
    public partial class addtables1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Communication",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CommDate = table.Column<DateTime>(nullable: false),
                    CommText = table.Column<string>(maxLength: 64000, nullable: true),
                    ContactID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Communication", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Config",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    DataPeriod = table.Column<string>(maxLength: 1, nullable: true),
                    DataProcessed = table.Column<DateTime>(nullable: false),
                    DataRecieved = table.Column<DateTime>(nullable: false),
                    DataUploaded = table.Column<DateTime>(nullable: false),
                    ExternalProcess = table.Column<string>(nullable: true),
                    Function = table.Column<string>(maxLength: 1, nullable: true),
                    MarketID = table.Column<int>(nullable: false),
                    PagesApproved = table.Column<DateTime>(nullable: false),
                    ProcessEndTIme = table.Column<DateTime>(nullable: false),
                    ProcessStartTime = table.Column<DateTime>(nullable: false),
                    ProofSent = table.Column<DateTime>(nullable: false),
                    Summary = table.Column<string>(nullable: true),
                    WholesalerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Config", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EMail = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    WholesalerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Processlog",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Comment = table.Column<string>(nullable: true),
                    ConfigID = table.Column<int>(nullable: false),
                    Logdate = table.Column<DateTime>(nullable: false),
                    User = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processlog", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Wholesaler",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BookContact1ID = table.Column<int>(nullable: false),
                    BookContactID = table.Column<int>(nullable: false),
                    BookFileID = table.Column<int>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    CustFileID = table.Column<int>(nullable: false),
                    CustomerFeed = table.Column<bool>(nullable: false),
                    DailyFeed = table.Column<bool>(nullable: false),
                    ETSLocation = table.Column<string>(nullable: true),
                    ETSUser = table.Column<bool>(nullable: false),
                    ITContactID = table.Column<int>(nullable: false),
                    InBook = table.Column<bool>(nullable: false),
                    InvFileID = table.Column<int>(nullable: false),
                    Market = table.Column<string>(maxLength: 5, nullable: true),
                    Online = table.Column<bool>(nullable: false),
                    OrderContactID = table.Column<int>(nullable: false),
                    WebContact1ID = table.Column<int>(nullable: false),
                    WebContactID = table.Column<int>(nullable: false),
                    WholesalerCode = table.Column<string>(maxLength: 6, nullable: true),
                    WholesalerName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wholesaler", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Communication");

            migrationBuilder.DropTable(
                name: "Config");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Processlog");

            migrationBuilder.DropTable(
                name: "Wholesaler");
        }
    }
}
