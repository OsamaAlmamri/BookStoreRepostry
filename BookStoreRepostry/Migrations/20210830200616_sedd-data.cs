using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreRepostry.Migrations
{
    public partial class sedddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "name" },
                values: new object[] { 10, "osama" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
