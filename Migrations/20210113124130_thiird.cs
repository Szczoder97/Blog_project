using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog_project.Migrations
{
    public partial class thiird : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "postId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "postId",
                table: "Comments");
        }
    }
}
