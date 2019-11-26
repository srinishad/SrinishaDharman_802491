using Microsoft.EntityFrameworkCore.Migrations;

namespace Mod.Authenticateservice.Migrations
{
    public partial class login : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mentor",
                columns: table => new
                {
                    MentorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MentorName = table.Column<string>(nullable: true),
                    MentorEmail = table.Column<string>(nullable: true),
                    MentorNumber = table.Column<long>(nullable: false),
                    MentorPassword = table.Column<string>(nullable: true),
                    MentorSkills = table.Column<string>(nullable: true),
                    MentorExperience = table.Column<int>(nullable: false),
                    MentorTimeslot = table.Column<string>(nullable: true),
                    MentorAvailability = table.Column<bool>(nullable: false),
                    MentorActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentor", x => x.MentorId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    UserEmail = table.Column<string>(nullable: true),
                    UserNumber = table.Column<long>(nullable: false),
                    UserPassword = table.Column<string>(nullable: true),
                    UserActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mentor");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
