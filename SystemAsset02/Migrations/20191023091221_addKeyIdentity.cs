using Microsoft.EntityFrameworkCore.Migrations;

namespace SystemAsset02.Migrations
{
    public partial class addKeyIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddUniqueConstraint(
                name: "AK_AspNetUsers_ID_UserI",
                table: "AspNetUsers",
                column: "ID_UserI");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_AspNetUsers_ID_UserI",
                table: "AspNetUsers");
        }
    }
}
