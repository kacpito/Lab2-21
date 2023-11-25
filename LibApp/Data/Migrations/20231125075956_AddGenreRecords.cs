using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibApp.Data.Migrations
{
    public partial class AddGenreRecords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Genres VALUES ('gatunek 1')");
            migrationBuilder.Sql("Insert into Genres VALUES ('gatunek 2')");
            migrationBuilder.Sql("Insert into Genres VALUES ('gatunek 3')");
            migrationBuilder.Sql("Insert into Genres VALUES ('gatunek 4')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
