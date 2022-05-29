using MuhammetAliDemir.TP.Net.Hw2.Part2.Core.Entities;

namespace MuhammetAliDemir.TP.Net.Hw2.Part2.Entities
{
    public class School : BaseEntity
    {
        public List<Classroom> Classrooms { get; set; }
       
    }
}
