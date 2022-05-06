using Microsoft.EntityFrameworkCore.Migrations;

namespace module_10.University.Infrastructure.Sql.Migrations.Migrations
{
    public partial class addDependencieLectureLecturer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Lectures_LectureDbId",
                table: "Attendances");

            migrationBuilder.DropIndex(
                name: "IX_Attendances_LectureDbId",
                table: "Attendances");

            migrationBuilder.DropColumn(
                name: "LectureDbId",
                table: "Attendances");

            migrationBuilder.CreateIndex(
                name: "IX_Lectures_LecturerId",
                table: "Lectures",
                column: "LecturerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lectures_Lecturers_LecturerId",
                table: "Lectures",
                column: "LecturerId",
                principalTable: "Lecturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lectures_Lecturers_LecturerId",
                table: "Lectures");

            migrationBuilder.DropIndex(
                name: "IX_Lectures_LecturerId",
                table: "Lectures");

            migrationBuilder.AddColumn<int>(
                name: "LectureDbId",
                table: "Attendances",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_LectureDbId",
                table: "Attendances",
                column: "LectureDbId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Lectures_LectureDbId",
                table: "Attendances",
                column: "LectureDbId",
                principalTable: "Lectures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
