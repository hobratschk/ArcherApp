using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Archers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Group = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Archers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventAScores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ArcherId = table.Column<int>(type: "INTEGER", nullable: true),
                    TargetA = table.Column<int>(type: "INTEGER", nullable: false),
                    TargetB = table.Column<int>(type: "INTEGER", nullable: false),
                    TargetC = table.Column<int>(type: "INTEGER", nullable: false),
                    TargetD = table.Column<int>(type: "INTEGER", nullable: false),
                    TargetE = table.Column<int>(type: "INTEGER", nullable: false),
                    TargetF = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventAScores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventAScores_Archers_ArcherId",
                        column: x => x.ArcherId,
                        principalTable: "Archers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EventBScores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ArcherId = table.Column<int>(type: "INTEGER", nullable: true),
                    TargetA = table.Column<int>(type: "INTEGER", nullable: false),
                    TargetB = table.Column<int>(type: "INTEGER", nullable: false),
                    TargetC = table.Column<int>(type: "INTEGER", nullable: false),
                    TargetD = table.Column<int>(type: "INTEGER", nullable: false),
                    TargetE = table.Column<int>(type: "INTEGER", nullable: false),
                    TimePenalty = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventBScores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventBScores_Archers_ArcherId",
                        column: x => x.ArcherId,
                        principalTable: "Archers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventAScores_ArcherId",
                table: "EventAScores",
                column: "ArcherId");

            migrationBuilder.CreateIndex(
                name: "IX_EventBScores_ArcherId",
                table: "EventBScores",
                column: "ArcherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventAScores");

            migrationBuilder.DropTable(
                name: "EventBScores");

            migrationBuilder.DropTable(
                name: "Archers");
        }
    }
}
