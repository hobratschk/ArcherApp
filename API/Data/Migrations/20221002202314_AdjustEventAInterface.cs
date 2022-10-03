using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    public partial class AdjustEventAInterface : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventAScores_Archers_ArcherId",
                table: "EventAScores");

            migrationBuilder.DropIndex(
                name: "IX_EventAScores_ArcherId",
                table: "EventAScores");

            migrationBuilder.AddColumn<string>(
                name: "ArcherName",
                table: "EventAScores",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArcherName",
                table: "EventAScores");

            migrationBuilder.CreateIndex(
                name: "IX_EventAScores_ArcherId",
                table: "EventAScores",
                column: "ArcherId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventAScores_Archers_ArcherId",
                table: "EventAScores",
                column: "ArcherId",
                principalTable: "Archers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
