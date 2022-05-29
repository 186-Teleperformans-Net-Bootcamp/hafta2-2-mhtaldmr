using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MuhammetAliDemir.TP.Net.Hw2.Part2.Migrations
{
    public partial class seedschool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Schools (Name) VALUES ('Highway School')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Schools");
        }
    }
}
