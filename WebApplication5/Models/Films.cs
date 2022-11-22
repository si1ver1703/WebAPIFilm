using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class Films
    {
        public int id { get; set; }
        public string title { get; set; }
        public string desc { get; set; }
        public int rating { get; set; }
    }

    public class FilmContext : DbContext
    {
        public DbSet <Films> film { get; set; }
    }
}