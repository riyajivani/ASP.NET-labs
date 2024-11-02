using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCdemo.Models
{
    public class FacultyContext : DbContext
    {
        public DbSet<Faculty>  faculties{get;set;} 
    }
}