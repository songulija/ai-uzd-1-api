using Microsoft.EntityFrameworkCore.Migrations;

namespace AI_Uzd_1_API.Migrations
{
    public partial class createdDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SportId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_Sport_SportId",
                        column: x => x.SportId,
                        principalTable: "Sport",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamId = table.Column<int>(type: "int", nullable: true),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                    { 13, 209, "Marek Blaževič", "Puolejas", 1, 114 },
                    { 9, 187, "Karim Benzema", "Puolejas", 2, 85 },
                    { 8, 183, "Toni Kroos", "Puolejas", 2, 76 },
                    { 7, 175, "Eden Hazard", "Puolejas", 2, 75 },
                    { 6, 180, "José Ignacio Fernández Iglesias", "Gynejas", 2, 76 },
                    { 5, 191, "Raphaël Varane", "Gynejas", 2, 81 },
                    { 4, 186, "Eder Militao", "Gynejas", 2, 79 },
                    { 3, 184, "Sergio Ramos", "Gynejas", 2, 85 },
                    { 10, 174, "Luka Modrić", "Puolejas", 2, 66 },
                    { 2, 173, "Dani Carvajal", "Gynejas", 2, 73 },
                    { 20, 211, "Joffrey Lauvergne", "Puolejas", 1, 118 },
                    { 19, 190, "Titas Sargiūnas", "Gynejas", 1, 82 },
                    { 18, 205, "Paulius Jankūnas", "Puolejas", 1, 113 },
                    { 17, 195, "Artūras Milaknis", "Gynejas", 1, 90 },
                    { 16, 201, "Niels Giffey", "Puolejas", 1, 93 },
                    { 15, 206, "Regimantas Miniotas", "Puolejas", 1, 105 },
                    { 14, 196, "Mantas Kalnietis", "Gynejas", 1, 90 },
                    { 1, 199, "Thibaut Courtois", "Gynejas", 2, 96 },
                    { 11, 182, "Marco Asensio", "Puolejas", 2, 75 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamId",
                table: "Players",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_SportId",
                table: "Teams",
                column: "SportId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Sport");
        }
    }
}
