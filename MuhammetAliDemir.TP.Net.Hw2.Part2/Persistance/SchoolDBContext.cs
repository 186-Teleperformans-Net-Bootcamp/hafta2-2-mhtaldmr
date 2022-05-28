using Microsoft.EntityFrameworkCore;

namespace MuhammetAliDemir.TP.Net.Hw2.Part2.Persistance
{
    public class SchoolDBContext : DbContext
    {
        public SchoolDBContext(DbContextOptions<SchoolDBContext> options) : base(options)
        {
        }


    }
}
