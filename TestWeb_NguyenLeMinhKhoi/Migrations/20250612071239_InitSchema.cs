using Microsoft.EntityFrameworkCore.Migrations;

namespace TestWeb_NguyenLeMinhKhoi.Migrations
{
    public partial class InitSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Author = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Price", "Quantity", "Title" },
                values: new object[,]
                {
                    { 1, "Nguyễn Tấn Thành", 300m, 2, "Học CSS" },
                    { 2, "Phạm Đức Trọng", 200m, 3, "Học Java" },
                    { 3, "Phạm Tú", 500m, 5, "Học Java Nâng Cao" },
                    { 4, "Nguyễn Duy", 200m, 1, "Kiến thức Word cơ bản" },
                    { 5, "Phạm Đức Trọng", 200m, 1, "Lịch sử" },
                    { 6, "Phạm Đức Trọng", 200m, 1, "Lịch sử VN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
