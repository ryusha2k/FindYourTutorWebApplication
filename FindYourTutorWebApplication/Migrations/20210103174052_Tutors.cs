using Microsoft.EntityFrameworkCore.Migrations;

namespace FindYourTutorWebApp.Migrations
{
    public partial class Tutors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BirthName",
                table: "Tutor",
                newName: "BirthDate");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Tutor",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Tutor");

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "Tutor",
                newName: "BirthName");
        }
    }
}
