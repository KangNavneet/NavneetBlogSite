using Microsoft.EntityFrameworkCore.Migrations;

namespace NavneetBlogSite.Data.Migrations
{
    public partial class neetu1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPost_BlogInfo_BlogInfoId",
                table: "BlogPost");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogPost_BlogPost_BlogPostId",
                table: "BlogPost");

            migrationBuilder.DropTable(
                name: "AuthorDetail");

            migrationBuilder.DropTable(
                name: "BlogInfo");

            migrationBuilder.DropIndex(
                name: "IX_BlogPost_BlogInfoId",
                table: "BlogPost");

            migrationBuilder.DropIndex(
                name: "IX_BlogPost_BlogPostId",
                table: "BlogPost");

            migrationBuilder.DropColumn(
                name: "BlogInfoId",
                table: "BlogPost");

            migrationBuilder.DropColumn(
                name: "BlogPostId",
                table: "BlogPost");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogInfoId",
                table: "BlogPost",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BlogPostId",
                table: "BlogPost",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BlogInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuthorDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogInfoId = table.Column<int>(type: "int", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthorDetail_BlogInfo_BlogInfoId",
                        column: x => x.BlogInfoId,
                        principalTable: "BlogInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogPost_BlogInfoId",
                table: "BlogPost",
                column: "BlogInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPost_BlogPostId",
                table: "BlogPost",
                column: "BlogPostId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorDetail_BlogInfoId",
                table: "AuthorDetail",
                column: "BlogInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPost_BlogInfo_BlogInfoId",
                table: "BlogPost",
                column: "BlogInfoId",
                principalTable: "BlogInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPost_BlogPost_BlogPostId",
                table: "BlogPost",
                column: "BlogPostId",
                principalTable: "BlogPost",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
