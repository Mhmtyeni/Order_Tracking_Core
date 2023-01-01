using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mvc.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "OrderLogs");

            migrationBuilder.AddColumn<DateTime>(
                name: "AcceptDate",
                table: "Orders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AcceptDate",
                table: "OrderLogs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CancelDate",
                table: "OrderLogs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CompletedDate",
                table: "OrderLogs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NoStockDate",
                table: "OrderLogs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderDate",
                table: "OrderLogs",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcceptDate",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderDate",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "AcceptDate",
                table: "OrderLogs");

            migrationBuilder.DropColumn(
                name: "CancelDate",
                table: "OrderLogs");

            migrationBuilder.DropColumn(
                name: "CompletedDate",
                table: "OrderLogs");

            migrationBuilder.DropColumn(
                name: "NoStockDate",
                table: "OrderLogs");

            migrationBuilder.DropColumn(
                name: "OrderDate",
                table: "OrderLogs");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "OrderLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
