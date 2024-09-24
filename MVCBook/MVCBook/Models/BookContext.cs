using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace MVCBook.Models
{
    public class BookContext : DbContext
    {
        public DbSet<Book> books { get; set; }
    }
}