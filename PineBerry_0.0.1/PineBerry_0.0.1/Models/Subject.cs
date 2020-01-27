using System.ComponentModel.DataAnnotations;

namespace PineBerry_0._0._1.Models
{
    public class Subject
    {
        [Key]
        public int SubjectNo { get; set; }

        [Required]
        public string Name { get; set; }
    }
}