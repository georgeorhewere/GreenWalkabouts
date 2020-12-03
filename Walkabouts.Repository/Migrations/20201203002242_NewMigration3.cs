using Microsoft.EntityFrameworkCore.Migrations;

namespace Walkabouts.Repository.Migrations
{
    public partial class NewMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_TEntitys_UserProfileId",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TEntitys",
                table: "TEntitys");

            migrationBuilder.RenameTable(
                name: "TEntitys",
                newName: "UserProfiles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserProfiles",
                table: "UserProfiles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_UserProfiles_UserProfileId",
                table: "AspNetUsers",
                column: "UserProfileId",
                principalTable: "UserProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_UserProfiles_UserProfileId",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserProfiles",
                table: "UserProfiles");

            migrationBuilder.RenameTable(
                name: "UserProfiles",
                newName: "TEntitys");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TEntitys",
                table: "TEntitys",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_TEntitys_UserProfileId",
                table: "AspNetUsers",
                column: "UserProfileId",
                principalTable: "TEntitys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
