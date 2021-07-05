using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreMvcTask.Migrations
{
    public partial class addmigrationmigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "kullanicilars",
                columns: table => new
                {
                    Kullanici_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kullanici_Adi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kullanicilars", x => x.Kullanici_ID);
                });

            migrationBuilder.CreateTable(
                name: "musterilers",
                columns: table => new
                {
                    Musterı_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyadi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    iletisim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    eposta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Domain_Adi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Domain_Sure = table.Column<int>(type: "int", nullable: false),
                    Firma_Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_musterilers", x => x.Musterı_ID);
                });

            migrationBuilder.CreateTable(
                name: "taleplers",
                columns: table => new
                {
                    Talep_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eposta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mesaj = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_taleplers", x => x.Talep_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "kullanicilars");

            migrationBuilder.DropTable(
                name: "musterilers");

            migrationBuilder.DropTable(
                name: "taleplers");
        }
    }
}
