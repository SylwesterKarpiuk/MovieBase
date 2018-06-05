using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieBase.Models
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext()
            : base("MovieBase")
        {
        }
        public DbSet<MovieDb> MovieDb { get; set; }
    }
}