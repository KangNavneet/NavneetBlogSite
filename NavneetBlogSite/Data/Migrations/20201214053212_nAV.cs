using Microsoft.EntityFrameworkCore.Migrations;

namespace NavneetBlogSite.Data.Migrations
{
    public partial class nAV : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userName = table.Column<string>(maxLength: 60, nullable: false),
                    email = table.Column<string>(nullable: false),
                    BlogInfoId = table.Column<int>(nullable: true)
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

            migrationBuilder.CreateTable(
                name: "BlogPost",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 60, nullable: false),
                    Title = table.Column<string>(maxLength: 60, nullable: false),
                    Content = table.Column<string>(maxLength: 1060, nullable: false),
                    AuthorEmail = table.Column<string>(maxLength: 60, nullable: false),
                    BlogInfoId = table.Column<int>(nullable: true),
                    BlogPostId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogPost_BlogInfo_BlogInfoId",
                        column: x => x.BlogInfoId,
                        principalTable: "BlogInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BlogPost_BlogPost_BlogPostId",
                        column: x => x.BlogPostId,
                        principalTable: "BlogPost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorDetail_BlogInfoId",
                table: "AuthorDetail",
                column: "BlogInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPost_BlogInfoId",
                table: "BlogPost",
                column: "BlogInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPost_BlogPostId",
                table: "BlogPost",
                column: "BlogPostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorDetail");

            migrationBuilder.DropTable(
                name: "BlogPost");

            migrationBuilder.DropTable(
                name: "BlogInfo");
        }
    }
}
