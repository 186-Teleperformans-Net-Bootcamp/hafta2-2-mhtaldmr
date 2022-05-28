namespace MuhammetAliDemir.TP.Net.Hw2.Part2.Entities
{
    public class Student : BaseClass
    {
        public Class Class { get; set; }
        public School School { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
