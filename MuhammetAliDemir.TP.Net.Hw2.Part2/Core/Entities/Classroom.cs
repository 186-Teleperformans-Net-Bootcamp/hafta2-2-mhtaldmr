using MuhammetAliDemir.TP.Net.Hw2.Part2.Core.Entities;

namespace MuhammetAliDemir.TP.Net.Hw2.Part2.Entities
{
    public class Classroom : BaseEntity
    {
        public List<Course> Courses { get; set; }
        public List<Student> Students { get; set; }
    }
}