using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_LAb.Migrations
{
    public partial class RemoveTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Test",
                table: "Actors");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Test",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
