using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace FreightAppASP.Migrations.Carrier
{
    public partial class CarrierMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carrier",
                columns: table => new
                {
                    CarrierId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AccountingContactEmail = table.Column<string>(nullable: true),
                    AccountingContactName = table.Column<string>(nullable: true),
                    AccountingContactPhone = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    DbaName = table.Column<string>(nullable: true),
                    DispatchContactEmail = table.Column<string>(nullable: true),
                    DispatchContactName = table.Column<string>(nullable: true),
                    DispatchContactPhone = table.Column<string>(nullable: true),
                    DotNumber = table.Column<int>(nullable: false),
                    Fax = table.Column<string>(nullable: true),
                    IsTaxtId = table.Column<bool>(nullable: false),
                    MailingAddress = table.Column<string>(nullable: true),
                    MailingCity = table.Column<string>(nullable: true),
                    MailingState = table.Column<string>(nullable: true),
                    MailingZip = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    PhysicalAddress = table.Column<string>(nullable: true),
                    PhysicalCity = table.Column<string>(nullable: true),
                    PhysicalState = table.Column<string>(nullable: true),
                    PhysicalZip = table.Column<string>(nullable: true),
                    PrimaryContactEmail = table.Column<string>(nullable: true),
                    PrimaryContactName = table.Column<string>(nullable: true),
                    PrimaryContactPhone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrier", x => x.CarrierId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Carrier");
        }
    }
}
