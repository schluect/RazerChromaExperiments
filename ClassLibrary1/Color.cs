using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ClassLibrary1
{
    public class Color
    {
        [Key]
        public int Id { get; set; }
        public string ColorValue { get; set; }
        [Required]
        public DateTime QueueDateTime { get; set; }
        public DateTime? ActivatedDateTime { get; set; }
    }
}