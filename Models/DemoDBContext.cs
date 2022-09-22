using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Assignment_WAD.Models
{
    public class DemoDBContext : DbContext
    {
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DemoDBContext() : base("name=DemoDbConnect")
        {

        }
    }
}