using Microsoft.EntityFrameworkCore;
using MuhammetAliDemir.TP.Net.Hw2.Part2.Entities;

namespace MuhammetAliDemir.TP.Net.Hw2.Part2.Persistance
{
    public class SchoolDBContext : DbContext
    {
        public SchoolDBContext(DbContextOptions<SchoolDBContext> options) : base(options)
        {
        }

        public DbSet<School> Schools { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Course> Courses { get; set; }

    }
}
