using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    public partial class AddArcherIdToScores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventAScores_Archers_ArcherId",
                table: "EventAScores");

            migrationBuilder.DropForeignKey(
                name: "FK_EventBScores_Archers_ArcherId",
                table: "EventBScores");

            migrationBuilder.AlterColumn<int>(
                name: "ArcherId",
                table: "EventBScores",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ArcherId",
                table: "EventAScores",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EventAScores_Archers_ArcherId",
                table: "EventAScores",
                column: "ArcherId",
                principalTable: "Archers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EventBScores_Archers_ArcherId",
                table: "EventBScores",
                column: "ArcherId",
                principalTable: "Archers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventAScores_Archers_ArcherId",
                table: "EventAScores");

            migrationBuilder.DropForeignKey(
                name: "FK_EventBScores_Archers_ArcherId",
                table: "EventBScores");

            migrationBuilder.AlterColumn<int>(
                name: "ArcherId",
                table: "EventBScores",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "ArcherId",
                table: "EventAScores",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_EventAScores_Archers_ArcherId",
                table: "EventAScores",
                column: "ArcherId",
                principalTable: "Archers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EventBScores_Archers_ArcherId",
                table: "EventBScores",
                column: "ArcherId",
                principalTable: "Archers",
                principalColumn: "Id");
        }
    }
}
