using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LTSQuız.Migrations
{
    public partial class mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KartAltGrupları",
                columns: table => new
                {
                    AltGrupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AltGrupAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KartAltGrupları", x => x.AltGrupID);
                });

            migrationBuilder.CreateTable(
                name: "KartGrupları",
                columns: table => new
                {
                    GrupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GrupAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KartGrupları", x => x.GrupID);
                });

            migrationBuilder.CreateTable(
                name: "Kartlar",
                columns: table => new
                {
                    KartID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Unvan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VergiDairesi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VergiNo = table.Column<int>(type: "int", nullable: false),
                    Tc = table.Column<int>(type: "int", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TipID = table.Column<int>(type: "int", nullable: false),
                    TurID = table.Column<int>(type: "int", nullable: false),
                    GrupID = table.Column<int>(type: "int", nullable: false),
                    AltGrupID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kartlar", x => x.KartID);
                });

            migrationBuilder.CreateTable(
                name: "KartTipleri",
                columns: table => new
                {
                    TipID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KartTipleri", x => x.TipID);
                });

            migrationBuilder.CreateTable(
                name: "KartTurleri",
                columns: table => new
                {
                    TurID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TurAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KartTurleri", x => x.TurID);
                });

            migrationBuilder.CreateTable(
                name: "Kullanıcılar",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonNo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanıcılar", x => x.UserID);
                });

            migrationBuilder.InsertData(
                table: "KartAltGrupları",
                columns: new[] { "AltGrupID", "AltGrupAdi" },
                values: new object[,]
                {
                    { 1, "AltGrup1" },
                    { 2, "AltGrup2" }
                });

            migrationBuilder.InsertData(
                table: "KartGrupları",
                columns: new[] { "GrupID", "GrupAdi" },
                values: new object[,]
                {
                    { 1, "Grup1" },
                    { 2, "Grup2" }
                });

            migrationBuilder.InsertData(
                table: "KartTipleri",
                columns: new[] { "TipID", "TipAdi" },
                values: new object[,]
                {
                    { 1, "Banka Kartı" },
                    { 2, "Kredi Kartı" }
                });

            migrationBuilder.InsertData(
                table: "KartTurleri",
                columns: new[] { "TurID", "TurAdi" },
                values: new object[,]
                {
                    { 1, "Klasik Kart" },
                    { 2, "Silver Kart" },
                    { 3, "Gold Kart" },
                    { 4, "Platin Kart" }
                });

            migrationBuilder.InsertData(
                table: "Kartlar",
                columns: new[] { "KartID", "Adres", "AltGrupID", "GrupID", "Tc", "TipID", "TurID", "Unvan", "VergiDairesi", "VergiNo" },
                values: new object[,]
                {
                    { 1, "İstanbul İkitelli", 0, 0, 111111111, 0, 0, "?????", "Sultangazi", 5456464 },
                    { 2, "İstanbul İkitelli", 0, 0, 222222222, 0, 0, "?????", "Sultangazi", 5456464 },
                    { 3, "İstanbul İkitelli", 0, 0, 333333333, 0, 0, "?????", "Sultangazi", 5456464 },
                    { 4, "İstanbul İkitelli", 0, 0, 444444444, 0, 0, "?????", "Sultangazi", 5456464 }
                });

            migrationBuilder.InsertData(
                table: "Kullanıcılar",
                columns: new[] { "UserID", "Ad", "Email", "KullaniciAdi", "Sifre", "Soyad", "TelefonNo" },
                values: new object[,]
                {
                    { 1, "Fatih Serdar", "fatihserdarkrts@gmail.com", "fatihserdarkrts", "123456", "Karataş", "05300220158" },
                    { 2, "Tahir", "tahirkrts@gmail.com", "tahirkrts", "123456", "Karataş", "05300220158" },
                    { 3, "Emine", "eminekrts@gmail.com", "eminekrts", "123456", "Karataş", "05300220158" },
                    { 4, "Fatma Sude", "fatmasudekrts@gmail.com", "fatmasudekrts", "123456", "Karataş", "05300220158" },
                    { 5, "Osman Efe", "fatmasudekrts@gmail.com", "osmanefekrts", "123456", "Karataş", "05300220158" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KartAltGrupları");

            migrationBuilder.DropTable(
                name: "KartGrupları");

            migrationBuilder.DropTable(
                name: "Kartlar");

            migrationBuilder.DropTable(
                name: "KartTipleri");

            migrationBuilder.DropTable(
                name: "KartTurleri");

            migrationBuilder.DropTable(
                name: "Kullanıcılar");
        }
    }
}
