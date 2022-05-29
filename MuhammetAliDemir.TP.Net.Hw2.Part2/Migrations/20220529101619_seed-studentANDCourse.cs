using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MuhammetAliDemir.TP.Net.Hw2.Part2.Migrations
{
    public partial class seedstudentANDCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Courses (Name,ClassroomId) VALUES ('Math',1)");
            migrationBuilder.Sql("INSERT INTO Courses (Name,ClassroomId) VALUES ('Science',2)");
            migrationBuilder.Sql("INSERT INTO Courses (Name,ClassroomId) VALUES ('Music',3)");

            migrationBuilder.Sql("INSERT INTO Students (Name,ClassroomId) VALUES ('Ali',1)");
            migrationBuilder.Sql("INSERT INTO Students (Name,ClassroomId) VALUES ('Ayşe',2)");
            migrationBuilder.Sql("INSERT INTO Students (Name,ClassroomId) VALUES ('Mehmet',3)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Students");
            migrationBuilder.Sql("DELETE FROM Courses");
        }
    }
}
