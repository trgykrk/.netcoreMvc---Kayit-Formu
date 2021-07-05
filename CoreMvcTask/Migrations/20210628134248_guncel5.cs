using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreMvcTask.Migrations
{
    public partial class guncel5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Uzanti_ID",
                table: "musterilers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_musterilers_Uzanti_ID",
                table: "musterilers",
                column: "Uzanti_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_musterilers_uzantilars_Uzanti_ID",
                table: "musterilers",
                column: "Uzanti_ID",
                principalTable: "uzantilars",
                principalColumn: "Uzanti_ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_musterilers_uzantilars_Uzanti_ID",
                table: "musterilers");

            migrationBuilder.DropIndex(
                name: "IX_musterilers_Uzanti_ID",
                table: "musterilers");

            migrationBuilder.DropColumn(
                name: "Uzanti_ID",
                table: "musterilers");
        }
    }
}
