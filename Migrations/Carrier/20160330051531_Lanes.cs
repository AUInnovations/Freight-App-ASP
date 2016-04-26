using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace FreightAppASP.Migrations.Carrier
{
    public partial class Lanes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Carrier",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Rating", table: "Carrier");
        }
    }
}
