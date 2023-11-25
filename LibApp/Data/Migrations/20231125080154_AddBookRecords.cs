using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibApp.Data.Migrations
{
    public partial class AddBookRecords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Books VALUES ('tytul 1', 'autor 1', 1, GETDATE(), GETDATE(), 2)");
            migrationBuilder.Sql("Insert into Books VALUES ('tytul 2', 'autor 2', 2, GETDATE(), GETDATE(), 3)");
            migrationBuilder.Sql("Insert into Books VALUES ('tytul 3', 'autor 3', 3, GETDATE(), GETDATE(), 5)");
            migrationBuilder.Sql("Insert into Books VALUES ('tytul 4', 'autor 4', 4, GETDATE(), GETDATE(), 6)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
