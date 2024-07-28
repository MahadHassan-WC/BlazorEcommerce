using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class addCartItem2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GetCartItems",
                table: "GetCartItems");

            migrationBuilder.RenameTable(
                name: "GetCartItems",
                newName: "CartItems");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartItems",
                table: "CartItems",
                columns: new[] { "UserId", "ProductId", "ProductTypeId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CartItems",
                table: "CartItems");

            migrationBuilder.RenameTable(
                name: "CartItems",
                newName: "GetCartItems");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GetCartItems",
                table: "GetCartItems",
                columns: new[] { "UserId", "ProductId", "ProductTypeId" });
        }
    }
}
