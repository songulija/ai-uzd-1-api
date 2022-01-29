using Microsoft.EntityFrameworkCore.Migrations;

namespace AI_Uzd_1_API.Migrations
{
    public partial class seedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sport",
                columns: new[] { "Id", "Title" },
                values: new object[] { 1, "Krepšinis" });

            migrationBuilder.InsertData(
                table: "Sport",
                columns: new[] { "Id", "Title" },
                values: new object[] { 2, "Futbolas" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "SportId", "Title" },
                values: new object[] { 1, 1, "Žalgiris" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "SportId", "Title" },
                values: new object[] { 2, 2, "Real Madrid" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Height", "Name", "Position", "TeamId", "Weight" },
                values: new object[,]
                {
                    { 13, 209, "Marek Blaževič", "Centras", 1, 114 },
                    { 9, 187, "Karim Benzema", "Puolėjas", 2, 85 },
                    { 8, 183, "Toni Kroos", "Saugas", 2, 76 },
                    { 7, 175, "Eden Hazard", "Puolėjas", 2, 75 },
                    { 6, 180, "José Ignacio Fernández Iglesias", "Gynėjas", 2, 76 },
                    { 5, 191, "Raphaël Varane", "Gynėjas", 2, 81 },
                    { 4, 186, "Eder Militao", "Gynėjas", 2, 79 },
                    { 3, 184, "Sergio Ramos", "Gynėjas", 2, 85 },
                    { 10, 174, "Luka Modrić", "Saugas", 2, 66 },
                    { 2, 173, "Dani Carvajal", "Gynėjas", 2, 73 },
                    { 20, 211, "Joffrey Lauvergne", "Centras", 1, 118 },
                    { 19, 190, "Titas Sargiūnas", "Įžaidėjas", 1, 82 },
                    { 18, 205, "Paulius Jankūnas", "Sunkus kraštas", 1, 113 },
                    { 17, 195, "Artūras Milaknis", "Atakuojantis gynėjas", 1, 90 },
                    { 16, 201, "Niels Giffey", "Lengvas kraštas", 1, 93 },
                    { 15, 206, "Regimantas Miniotas", "Sunkus kraštas", 1, 105 },
                    { 14, 196, "Mantas Kalnietis", "Įžaidėjas", 1, 90 },
                    { 1, 199, "Thibaut Courtois", "Vartininkas", 2, 96 },
                    { 11, 182, "Marco Asensio", "Puolėjas", 2, 75 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
