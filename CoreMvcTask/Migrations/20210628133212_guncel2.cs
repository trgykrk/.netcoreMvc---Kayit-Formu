using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreMvcTask.Migrations
{
    public partial class guncel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Yetki_Kodu",
                table: "kullanicilars",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Yetki_Kodu",
                table: "kullanicilars");
        }
    }
}
