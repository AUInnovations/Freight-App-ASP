using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace FreightAppASP.Migrations.Carrier
{
    public partial class Lane : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lanes",
                columns: table => new
                {
                    LaneId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CarrierId = table.Column<int>(nullable: false),
                    DestinationCity = table.Column<string>(nullable: true),
                    OriginCity = table.Column<string>(nullable: true),
                    Radius = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lanes", x => x.LaneId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Lanes");
        }
    }
}
