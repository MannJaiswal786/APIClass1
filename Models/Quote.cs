using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIClass1.Models
{
    public class Quote
    {
        [Key]
        public int QuoteID { get; set; }
        public string QuoteType { get; set; }
        public string Contact { get; set; }
        public string Task { get; set; }
        public DateTime DueDate { get; set; }
        public string TaskType { get; set; }

    }
}
