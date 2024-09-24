using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCBook.Models
{
    [Table("Book")]
    public class Book
    {
        [Key]
        public int isbn_no { get; set; }
        public string bk_name { get; set; }
        public int cost { get; set; }
        public string display {  get; set; }
    }
}