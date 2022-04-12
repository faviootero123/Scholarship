using Microsoft.EntityFrameworkCore.Migrations;

namespace WCS.Data.Migrations
{
    public partial class AddedStatusForInvite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Invites",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Invites");
        }
    }
}
