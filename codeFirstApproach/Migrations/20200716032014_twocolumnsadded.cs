﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace codeFirstApproach.Migrations
{
    public partial class twocolumnsadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Persons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Persons",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Persons");
        }
    }
}
