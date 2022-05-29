using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MuhammetAliDemir.TP.Net.Hw2.Part2.Migrations
{
    public partial class seedteacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Teachers (Name,CourseId) VALUES ('Hasan Hoca',1)");
            migrationBuilder.Sql("INSERT INTO Teachers (Name,CourseId) VALUES ('Can Hoca',2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Teachers");
        }
    }
}
