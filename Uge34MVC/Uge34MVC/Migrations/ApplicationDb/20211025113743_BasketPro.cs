using Microsoft.EntityFrameworkCore.Migrations;

namespace Uge34MVC.Migrations.ApplicationDb
{
    public partial class BasketPro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Basket_AspNetUsers_UserId1",
                table: "Basket");

            migrationBuilder.AlterColumn<string>(
                name: "UserId1",
                table: "Basket",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Basket_AspNetUsers_UserId1",
                table: "Basket",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Basket_AspNetUsers_UserId1",
                table: "Basket");

            migrationBuilder.AlterColumn<string>(
                name: "UserId1",
                table: "Basket",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Basket_AspNetUsers_UserId1",
                table: "Basket",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
