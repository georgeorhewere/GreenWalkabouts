using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Walkabouts.Repository.Migrations
{
    public partial class productConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Featured",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "StockLevel",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "UnitPrice",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "Featured", "ModifiedBy", "ModifiedOn", "ProductName", "RefId", "StockLevel", "UnitPrice" },
                values: new object[,]
                {
                    { 1L, 0L, new DateTime(2021, 6, 30, 16, 39, 13, 131, DateTimeKind.Local).AddTicks(6109), "", false, null, new DateTime(2021, 6, 30, 16, 39, 13, 131, DateTimeKind.Local).AddTicks(6151), "Samsung 50 inch", new Guid("5c1b96b7-263a-45eb-b15b-67f3eab99cee"), 15, 3400m },
                    { 2L, 0L, new DateTime(2021, 6, 30, 16, 39, 13, 131, DateTimeKind.Local).AddTicks(8308), "energy saving product", false, null, new DateTime(2021, 6, 30, 16, 39, 13, 131, DateTimeKind.Local).AddTicks(8310), "SkyRun Fridge", new Guid("547088db-f288-44b8-9156-353331943143"), 11, 4000m },
                    { 3L, 0L, new DateTime(2021, 6, 30, 16, 39, 13, 131, DateTimeKind.Local).AddTicks(8320), "", false, null, new DateTime(2021, 6, 30, 16, 39, 13, 131, DateTimeKind.Local).AddTicks(8322), "IPhone 6s", new Guid("72c82848-8c93-4705-8dcb-0f66d8a8e4a9"), 5, 400m },
                    { 4L, 0L, new DateTime(2021, 6, 30, 16, 39, 13, 131, DateTimeKind.Local).AddTicks(8330), "", false, null, new DateTime(2021, 6, 30, 16, 39, 13, 131, DateTimeKind.Local).AddTicks(8332), "OX Fan 10 inch", new Guid("0abdfbda-6f6a-4fd3-aa87-f441d11c2a62"), 15, 300m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Featured",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "StockLevel",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "Products");
        }
    }
}
