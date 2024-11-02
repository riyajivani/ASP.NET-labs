using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCdemo.Models
{
   
    public class Faculty
    {
        [Key]
        public int Id {  get; set; }
        public string Name { get; set; }

        public string Desg { get; set; }

        public string Dept { get; set; }
    }
}