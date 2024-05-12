using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class _add_ApplicantExpert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicantExperts",
                columns: table => new
                {
                    ApplicantExpertID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicantExpertName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicantExpertSurnameName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicantExpertMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicantExpertAge = table.Column<int>(type: "int", nullable: false),
                    ApplicantExpertGender = table.Column<int>(type: "int", nullable: false),
                    ApplicantExpertTitle = table.Column<int>(type: "int", nullable: false),
                    ApplicantExpertCV = table.Column<int>(type: "int", nullable: false),
                    MembershipDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicantExpertStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicantExperts", x => x.ApplicantExpertID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicantExperts");
        }
    }
}
