using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MuhammetAliDemir.TP.Net.Hw2.Part2.Core.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Column(Order =1)]
        public string Name { get; set; }
    }
}
