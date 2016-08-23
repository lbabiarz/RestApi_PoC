using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestApi_PoC_DAL.Models;

namespace RestApi_PoC_DAL
{
    public class SchoolContext : DbContext  
    {
        public  SchoolContext() : base() { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<StudentsGroup> Groups { get; set; }
    }
}
