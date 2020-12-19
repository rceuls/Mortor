using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mortor.Web.Migrations
{
    public partial class ImagePath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "ReportLines");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "ReportLines",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "ReportLines");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "ReportLines",
                type: "bytea",
                nullable: true);
        }
    }
}
