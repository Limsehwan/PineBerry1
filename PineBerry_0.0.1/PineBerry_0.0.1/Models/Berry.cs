using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PineBerry_0._0._1.Models
{
    public class Berry
    {
        [Key]
        public int BerriesNo { get; set; }

        [Required]
        public int SubjectNo { get; set; }

        [ForeignKey("SubjectNo")]
        public virtual Subject SubjectName { get; set;}
    }
}
