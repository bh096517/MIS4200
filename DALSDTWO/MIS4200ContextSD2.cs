using MIS4200.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MIS4200.DALSDTWO
{
    public class MIS4200ContextSD2 : DbContext 
    {
        public MIS4200ContextSD2() : base("name=DefaultConnection")
        {

        }
        public DbSet<Student> student { get; set; }
        public DbSet<Grade> grade { get; set; }
        public DbSet<Course> course { get; set; }
        public DbSet<instructor> Instructor { get; set; }
        public DbSet<Classes> classes { get; set; }
    }
}