using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace FreightAppASP.Migrations.Carrier
{
    public partial class KeepGoing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DestinationState",
                table: "Lanes",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "DestinationZip",
                table: "Lanes",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<string>(
                name: "OriginState",
                table: "Lanes",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "OriginZip",
                table: "Lanes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "DestinationState", table: "Lanes");
            migrationBuilder.DropColumn(name: "DestinationZip", table: "Lanes");
            migrationBuilder.DropColumn(name: "OriginState", table: "Lanes");
            migrationBuilder.DropColumn(name: "OriginZip", table: "Lanes");
        }
    }
}
