using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SCP.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostTitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    PostsId = table.Column<int>(nullable: false),
                    Admin = table.Column<string>(nullable: true),
                    CommentDate = table.Column<DateTime>(nullable: false),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostDetails", x => new { x.Id, x.PostsId });
                    table.ForeignKey(
                        name: "FK_PostDetails_Posts_PostsId",
                        column: x => x.PostsId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PostDetails_PostsId",
                table: "PostDetails",
                column: "PostsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostDetails");

            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
