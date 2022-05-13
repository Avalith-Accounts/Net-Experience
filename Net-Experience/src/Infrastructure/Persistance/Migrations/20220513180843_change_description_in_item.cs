using Microsoft.EntityFrameworkCore.Migrations;

namespace Net.Experience.Persistance.Migrations
{
    public partial class change_description_in_item : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Despription",
                table: "Items",
                newName: "Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Items",
                newName: "Despription");
        }
    }
}
