using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace dreamstarter_web.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Cpr = table.Column<int>(nullable: false),
                    Email = table.Column<string>(maxLength: 20, nullable: false),
                    Mobile = table.Column<string>(maxLength: 8, nullable: false),
                    Name = table.Column<string>(maxLength: 15, nullable: false),
                    Password = table.Column<string>(maxLength: 20, nullable: false),
                    Postcode = table.Column<string>(maxLength: 12, nullable: false),
                    ProfilePicture = table.Column<string>(nullable: true),
                    Street = table.Column<string>(maxLength: 20, nullable: false),
                    StreetNr = table.Column<string>(maxLength: 10, nullable: false),
                    Surname = table.Column<string>(maxLength: 15, nullable: false),
                    Town = table.Column<string>(maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Campaigns",
                columns: table => new
                {
                    CampaignId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AmountRaised = table.Column<double>(nullable: false),
                    AmountRequired = table.Column<double>(nullable: false),
                    DetailDescription = table.Column<string>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: false),
                    IsFinished = table.Column<bool>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    Synopsis = table.Column<string>(nullable: true),
                    ThemeImageFileName = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaigns", x => x.CampaignId);
                    table.ForeignKey(
                        name: "FK_Campaigns_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CampaignComments",
                columns: table => new
                {
                    CommentId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CampaignId = table.Column<int>(nullable: false),
                    Text = table.Column<string>(maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignComments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_CampaignComments_Campaigns_CampaignId",
                        column: x => x.CampaignId,
                        principalTable: "Campaigns",
                        principalColumn: "CampaignId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CampaignLikes",
                columns: table => new
                {
                    LikeCampaignId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CampaignId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignLikes", x => x.LikeCampaignId);
                    table.ForeignKey(
                        name: "FK_CampaignLikes_Campaigns_CampaignId",
                        column: x => x.CampaignId,
                        principalTable: "Campaigns",
                        principalColumn: "CampaignId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Incetiment",
                columns: table => new
                {
                    IncetimentId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CampaignId1 = table.Column<int>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incetiment", x => x.IncetimentId);
                    table.ForeignKey(
                        name: "FK_Incetiment_Campaigns_CampaignId1",
                        column: x => x.CampaignId1,
                        principalTable: "Campaigns",
                        principalColumn: "CampaignId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CampaignComments_CampaignId",
                table: "CampaignComments",
                column: "CampaignId");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignLikes_CampaignId",
                table: "CampaignLikes",
                column: "CampaignId");

            migrationBuilder.CreateIndex(
                name: "IX_Campaigns_UserId",
                table: "Campaigns",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Incetiment_CampaignId1",
                table: "Incetiment",
                column: "CampaignId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CampaignComments");

            migrationBuilder.DropTable(
                name: "CampaignLikes");

            migrationBuilder.DropTable(
                name: "Incetiment");

            migrationBuilder.DropTable(
                name: "Campaigns");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
