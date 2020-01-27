using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PineBerry_0._0._1.Models
{
    public class QnA
    {
        [Key]
        public int QnANo { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTime QuestionDate { get; set; }

        public string Answer { get; set; }
    }
}
