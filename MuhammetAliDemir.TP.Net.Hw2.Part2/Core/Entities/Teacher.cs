using MuhammetAliDemir.TP.Net.Hw2.Part2.Core.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace MuhammetAliDemir.TP.Net.Hw2.Part2.Entities
{
    public class Teacher : BaseEntity
    {
        public int CourseId { get; set; }

        [ForeignKey("CourseId")]
        public Course Course { get; set; }
    }
}
