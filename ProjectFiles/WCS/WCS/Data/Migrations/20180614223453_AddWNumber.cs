using Microsoft.EntityFrameworkCore.Migrations;

namespace WCS.Data.Migrations
{
    public partial class AddWNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WNumber",
                table: "StudentProfiles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WNumber",
                table: "StudentProfiles");
        }
    }
}
