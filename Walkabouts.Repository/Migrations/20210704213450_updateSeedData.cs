using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Walkabouts.Repository.Migrations
{
    public partial class updateSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RefId" },
                values: new object[] { new DateTime(2021, 7, 4, 22, 34, 49, 137, DateTimeKind.Local).AddTicks(7717), new DateTime(2021, 7, 4, 22, 34, 49, 137, DateTimeKind.Local).AddTicks(7764), new Guid("d6b3cc59-c695-40ca-bb6a-fc20be64978f") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "Description", "ModifiedOn", "ProductName", "RefId", "UnitPrice" },
                values: new object[] { new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(135), "Every single American needs to read Michael Knowles’s Speechless. I don’t mean ‘read it eventually.’ I mean: stop what you’re doing and pick up this boo", new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(139), "Speechless: Controlling Words, Controlling Minds Hardcover", new Guid("5e38f72c-a107-43f6-9533-d19a8fe56243"), 24.49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "Description", "ModifiedOn", "ProductName", "RefId", "UnitPrice" },
                values: new object[] { new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(154), "Next-level Hardware - Make every move count with a blazing-fast processor and our highest-resolution display\r\nAll-In-One Gaming - With backward compatibility, you can explore new titles and old favorites in the expansive Quest content library", new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(156), "Oculus Quest 2 — Advanced All-In-One Virtual Reality Headset ", new Guid("9989e3bb-7341-48f6-a834-e95517311ba8"), 299m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "Description", "ModifiedOn", "ProductName", "RefId", "UnitPrice" },
                values: new object[] { new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(164), "The Real 4K TV for all your entertainment needsLG UHD TV was made to entertain by taking everything you watch to a new level. Whether it's cinema, sports, or games, it delivers real 4K images with vivid color and fine detail. Enjoy more realistic images in four times the resolution of Full HD.", new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(166), "LG 65''Smart UHD 4K Satellite Ai ThinQ TV ", new Guid("26724d46-2d9a-4707-bfcf-c44f1da2fd07"), 378.89m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "Featured", "ModifiedBy", "ModifiedOn", "ProductName", "RefId", "StockLevel", "UnitPrice" },
                values: new object[,]
                {
                    { 19L, 0L, new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(367), "tool is self-opening; revolving punch is powerful and easy, giving you the capability to cleaning punch holes every time", false, null, new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(369), "General Tools 72 Leather Hole Punch Tool", new Guid("53cb842d-0f5f-4255-87a0-8b425f279387"), 83, 9.25m },
                    { 18L, 0L, new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(359), "Our hammocks are well made of 210T parachute nylon fabric, to be soft while breathable and quick dry, triple stitching to strength durability and security.", false, null, new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(361), "Camping Hammock for Outdoors Travel Backpacking", new Guid("0407eba9-4f6a-481b-b061-2a9dd1c823b3"), 95, 19.99m },
                    { 17L, 0L, new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(349), "Used on Drill Glass,Wood,Tile Bottles,Blocks Jars, Ceramic,Slate Mable, Granite Light Stone, and other hard surfaces", false, null, new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(351), "Diamond Drill Bit Set Hole, 15PCS Hole Saw Set", new Guid("1842b564-632e-4839-8b91-f8ec02cffbd0"), 186, 12.99m },
                    { 16L, 0L, new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(340), "Versatile light/fan: Ultra Bright 18 individual low powered LED bulbs. The fan has high and low settings to provide nice air circulation and lit up the tent nicely. You can orient in so many positions.", false, null, new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(343), "Odoland Portable LED Camping Lantern with Ceiling Fan", new Guid("8eb04d82-3697-4b01-9bfa-17442339fd64"), 15, 16.67m },
                    { 15L, 0L, new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(314), "3 Play Styles: TV Mode, Tabletop Mode, Handheld Mode\r\n                                         6.2-inch, multi-touch capacitive touch screen\r\n                                         4.5-9+ Hours of Battery Life will vary depending on software usage conditions\r\n                                         Connects over Wi-Fi for multiplayer gaming; Up to 8 consoles can be connected for local wireless multiplayer", false, null, new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(316), "Nintendo Switch with Neon Blue and Neon Red Joy‑Con", new Guid("53b4ea1d-0e72-4953-a3bd-715d69027a15"), 15, 314.95m },
                    { 14L, 0L, new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(306), "iPhone 7 is the 10th generation of Apple (Apple) mobile phone, released at 1:00 am Beijing time on September 8, 2016 at the San Francisco Graham Municipal Auditorium 2016 Apple Autumn New Product Launch Conference", false, null, new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(308), "Apple IPhone 7 4.7 Inch 2GB", new Guid("94b9e8f3-3b30-4f3e-8c02-71ef2c8f58e7"), 46, 230.3m },
                    { 12L, 0L, new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(290), "AMD Ryzen 7 4700U Octa-Core Mobile Processor (Up to 4.1 GHz) with Radeon Graphics; 8GB LPDDR4 Memory; 512GB PCIe NVMe SSD\r\n                                        14 Full HD Widescreen IPS LED - backlit display(1920 x 1080 resolution; 16:9 aspect ratio)\r\n                                        Intel wireless Wi - Fi 6 AX200 802.11ax; HD webcam(1280 x 720); Backlit keyboard; Fingerprint reader", false, null, new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(292), "Acer Swift 3 Thin & Light Laptop, 14 Full HD IPS", new Guid("42fc3261-b28c-4240-83b0-d89d58a386be"), 5, 618.92m },
                    { 11L, 0L, new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(282), "The iPhone stand is made of high-quality aluminum alloy with a nice finish. Stable and easy to watch Youtube or FaceTime. Besides, rubber non-slip pads protect the surface of your phone case and desk from scratches.", false, null, new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(284), "Lamicall Cell Phone Stand, Phone Dock", new Guid("273b710f-a377-4041-97b4-d14b5a821ec6"), 84, 7.99m },
                    { 10L, 0L, new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(273), "High pressure rainfall shower head: Our luxury bathroom rainhead is the perfect replacement that will jet out high-pressure rain of hot water so your whole body is doused with the downpour. You won’t go back to a normal shower again", false, null, new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(275), "SparkPod Shower Head", new Guid("93801d59-5da9-4a8d-ab2d-5c71e41ea1fa"), 132, 29.72m },
                    { 9L, 0L, new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(263), "With unique inspirational quote and time marker on it, this water bottle is great for measuring your daily intake of water, reminding you stay hydrated and drink enough water throughout the day. A must have for any fitness goals including weight loss and overall health.", false, null, new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(265), "Venture Pal Large 1 Gallon/128 OZ Motivational BPA Free Leakproof Water Bottle with Straw & Time Marker", new Guid("709dda71-a97d-4db9-aa2d-09b6e219df23"), 57, 14.99m },
                    { 8L, 0L, new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(252), "Lightweight feature makes it portable for using anywhere; Compact design performs well on any occasion; Perfect for RVs, boats, kitchens, tea shops, KTVs, offices, bars, restaurants, parties, gatherings, holidays, etc", false, null, new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(254), "VIVOHOME Electric Portable Compact Countertop Automatic Ice Cube Maker Machine", new Guid("26e0367c-4d09-4884-a541-7be9425a6f8b"), 73, 96.78m },
                    { 7L, 0L, new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(189), "[Face Masks]: Mouth Face Mask 3-ply With Elastic Earloops for Day-to-day protection\r\n                                      [Disposable Masks]: The disposable face mask is made from a supportive and powerful 3 - layered fabric for 3 - Way filter\r\n                                      [Disposable Face Masks]: Designed for a softer and smoother feel for Breathability all day long", false, null, new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(191), "Disposable Face Masks, Face Masks of 50 Pack Disposable Mask", new Guid("929044e3-c466-4272-b7ca-485e9d395ee9"), 100, 12.99m },
                    { 6L, 0L, new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(181), "", false, null, new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(183), "SUNGAIT Ultra Lightweight Rectangular Polarized Sunglasses", new Guid("65eef082-0075-4109-846a-2066e4114985"), 15, 300m },
                    { 13L, 0L, new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(298), "The 10.1 inch Tablet PC is equipped with high-performance 1.6GHz Quad-Core processor & Android 9.0 operating systems, capable of guaranteeing an extremely fluid gaming experience and a fast multimedia experience. With 2GB RAM and 32 GB internal storage, it's very suitable for running a number of entertainment applications without stucking, such as Netflix, Amazon Prime and Youtube", false, null, new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(300), "Tablet 10.1 inch Android 9.0 Tablet PC", new Guid("e148ed17-2c1b-49c6-aae7-ab8fc8de26a8"), 39, 99.99m },
                    { 5L, 0L, new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(173), "2 Outlets 3 USB Charging Ports(3.1A, 15W)", false, null, new DateTime(2021, 7, 4, 22, 34, 49, 138, DateTimeKind.Local).AddTicks(174), "Power Strip with USB ", new Guid("715dca48-ac35-4623-8a2a-035fe7f94e77"), 15, 9.38m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19L);

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
                columns: new[] { "CreatedOn", "Description", "ModifiedOn", "ProductName", "RefId", "UnitPrice" },
                values: new object[] { new DateTime(2021, 7, 1, 20, 14, 7, 416, DateTimeKind.Local).AddTicks(9973), "energy saving product", new DateTime(2021, 7, 1, 20, 14, 7, 416, DateTimeKind.Local).AddTicks(9975), "SkyRun Fridge", new Guid("57a1b119-80d9-45ad-a50a-32609f8ddd11"), 4000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "Description", "ModifiedOn", "ProductName", "RefId", "UnitPrice" },
                values: new object[] { new DateTime(2021, 7, 1, 20, 14, 7, 416, DateTimeKind.Local).AddTicks(9985), "", new DateTime(2021, 7, 1, 20, 14, 7, 416, DateTimeKind.Local).AddTicks(9987), "IPhone 6s", new Guid("3579f856-3d62-449b-877b-792f4945b1f9"), 400m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "Description", "ModifiedOn", "ProductName", "RefId", "UnitPrice" },
                values: new object[] { new DateTime(2021, 7, 1, 20, 14, 7, 416, DateTimeKind.Local).AddTicks(9993), "", new DateTime(2021, 7, 1, 20, 14, 7, 416, DateTimeKind.Local).AddTicks(9995), "OX Fan 10 inch", new Guid("21970f24-9af8-44c8-a9ee-9084c327bad5"), 300m });
        }
    }
}
