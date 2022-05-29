using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MuhammetAliDemir.TP.Net.Hw2.Part2.Migrations
{
    public partial class seedclassroom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Classrooms (Name,SchoolId) VALUES ('2-A',1)");
            migrationBuilder.Sql("INSERT INTO Classrooms (Name,SchoolId) VALUES ('2-B',1)");
            migrationBuilder.Sql("INSERT INTO Classrooms (Name,SchoolId) VALUES ('3-C',1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Classrooms");
        }
    }
}
