using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class _surname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ApplicantExpertSurnameName",
                table: "ApplicantExperts",
                newName: "ApplicantExpertSurname");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ApplicantExpertSurname",
                table: "ApplicantExperts",
                newName: "ApplicantExpertSurnameName");
        }
    }
}
