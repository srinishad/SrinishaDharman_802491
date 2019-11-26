﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Mod.TrainingService.Migrations
{
    public partial class train : Migration
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
                name: "Skills",
                columns: table => new
                {
                    SkillId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillName = table.Column<string>(nullable: true),
                    Toc = table.Column<string>(nullable: true),
                    Fee = table.Column<double>(nullable: false),
                    Duration = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.SkillId);
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

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    PaymentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Amount = table.Column<float>(nullable: false),
                    MentorId = table.Column<int>(nullable: false),
                    MentorAmount = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payment_Mentor_MentorId",
                        column: x => x.MentorId,
                        principalTable: "Mentor",
                        principalColumn: "MentorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Training_MentorId",
                table: "Training",
                column: "MentorId");

            migrationBuilder.CreateIndex(
                name: "IX_Training_SkillId",
                table: "Training",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Training_UserId",
                table: "Training",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_MentorId",
                table: "Payment",
                column: "MentorId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_UserId",
                table: "Payment",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Training_Mentor_MentorId",
                table: "Training",
                column: "MentorId",
                principalTable: "Mentor",
                principalColumn: "MentorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Training_Skills_SkillId",
                table: "Training",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "SkillId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Training_User_UserId",
                table: "Training",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Training_Mentor_MentorId",
                table: "Training");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_Skills_SkillId",
                table: "Training");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_User_UserId",
                table: "Training");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Mentor");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_Training_MentorId",
                table: "Training");

            migrationBuilder.DropIndex(
                name: "IX_Training_SkillId",
                table: "Training");

            migrationBuilder.DropIndex(
                name: "IX_Training_UserId",
                table: "Training");
        }
    }
}
