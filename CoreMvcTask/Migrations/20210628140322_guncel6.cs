using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreMvcTask.Migrations
{
    public partial class guncel6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Uzanti_Ref",
                table: "musterilers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Uzanti_Ref",
                table: "musterilers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
