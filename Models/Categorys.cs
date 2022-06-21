using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIClass1.Models
{
    public class Categorys
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
    }
}
