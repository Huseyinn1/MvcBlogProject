using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoginRegisterPage.Migrations
{
    public partial class UserUpdated2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfilImageFileName",
                table: "users",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValue: "noimage.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilImageFileName",
                table: "users");
        }
    }
}
