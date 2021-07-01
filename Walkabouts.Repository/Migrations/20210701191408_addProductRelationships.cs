using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Walkabouts.Repository.Migrations
{
    public partial class addProductRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductReviews",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumOfStars = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductId1 = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RefId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductReviews_Products_ProductId1",
                        column: x => x.ProductId1,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RefId" },
                values: new object[] { new DateTime(2021, 7, 1, 20, 14, 7, 416, DateTimeKind.Local).AddTicks(8490), new DateTime(2021, 7, 1, 20, 14, 7, 416, DateTimeKind.Local).AddTicks(8526), new Guid("baa4e4ff-ae21-459b-bc83-1e19583ee13e") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RefId" },
                values: new object[] { new DateTime(2021, 7, 1, 20, 14, 7, 416, DateTimeKind.Local).AddTicks(9973), new DateTime(2021, 7, 1, 20, 14, 7, 416, DateTimeKind.Local).AddTicks(9975), new Guid("57a1b119-80d9-45ad-a50a-32609f8ddd11") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RefId" },
                values: new object[] { new DateTime(2021, 7, 1, 20, 14, 7, 416, DateTimeKind.Local).AddTicks(9985), new DateTime(2021, 7, 1, 20, 14, 7, 416, DateTimeKind.Local).AddTicks(9987), new Guid("3579f856-3d62-449b-877b-792f4945b1f9") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RefId" },
                values: new object[] { new DateTime(2021, 7, 1, 20, 14, 7, 416, DateTimeKind.Local).AddTicks(9993), new DateTime(2021, 7, 1, 20, 14, 7, 416, DateTimeKind.Local).AddTicks(9995), new Guid("21970f24-9af8-44c8-a9ee-9084c327bad5") });

            migrationBuilder.CreateIndex(
                name: "IX_ProductReviews_ProductId1",
                table: "ProductReviews",
                column: "ProductId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductReviews");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RefId" },
                values: new object[] { new DateTime(2021, 6, 30, 16, 39, 13, 131, DateTimeKind.Local).AddTicks(6109), new DateTime(2021, 6, 30, 16, 39, 13, 131, DateTimeKind.Local).AddTicks(6151), new Guid("5c1b96b7-263a-45eb-b15b-67f3eab99cee") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RefId" },
                values: new object[] { new DateTime(2021, 6, 30, 16, 39, 13, 131, DateTimeKind.Local).AddTicks(8308), new DateTime(2021, 6, 30, 16, 39, 13, 131, DateTimeKind.Local).AddTicks(8310), new Guid("547088db-f288-44b8-9156-353331943143") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RefId" },
                values: new object[] { new DateTime(2021, 6, 30, 16, 39, 13, 131, DateTimeKind.Local).AddTicks(8320), new DateTime(2021, 6, 30, 16, 39, 13, 131, DateTimeKind.Local).AddTicks(8322), new Guid("72c82848-8c93-4705-8dcb-0f66d8a8e4a9") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RefId" },
                values: new object[] { new DateTime(2021, 6, 30, 16, 39, 13, 131, DateTimeKind.Local).AddTicks(8330), new DateTime(2021, 6, 30, 16, 39, 13, 131, DateTimeKind.Local).AddTicks(8332), new Guid("0abdfbda-6f6a-4fd3-aa87-f441d11c2a62") });
        }
    }
}
