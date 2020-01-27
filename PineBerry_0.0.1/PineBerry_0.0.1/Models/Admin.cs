using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PineBerry_0._0._1.Models
{
    public class Admin
    {
        [Key]
        public int AdminNo { get; set; }

        [Required]
        public string Id { get; set; }

        [Required]
        public string Pw { get; set; }

        [Required]
        public bool SuperAdmin { get; set; }
    }
}
