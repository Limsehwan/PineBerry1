using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PineBerry_0._0._1.Models
{
    public class Notice
    {
        [Key]
        public int NoticeNo { get; set; }

        [Required]
        public String Title { get; set; }
        
        [Required]
        public String Content { get; set; }

        [Required]
        public DateTime NoticeDate { get; set; }
    }
}
