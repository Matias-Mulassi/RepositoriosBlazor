using Microsoft.EntityFrameworkCore.Migrations;

namespace AppBlazorRealTimeCRUD.Server.Migrations
{
    public partial class changeNamePropertie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "ProgrammingLanguage",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ProgrammingLanguage",
                newName: "Nombre");
        }
    }
}
