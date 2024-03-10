using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Movies.Model;

namespace Movies.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext():base("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MoviesDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False") 
        { 
        
        }
        public DbSet<Movie> Movies { get; set; }
    }
}
