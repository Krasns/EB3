using EB3.Shared;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;

namespace EB3.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options ) : base( options ) 
        {

        }

        public DbSet<RomanNumeral> RomanNumerals { get; set; }
    }
}
