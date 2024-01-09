using APIAgencia.Models;
using Microsoft.EntityFrameworkCore;

namespace APIAgencia.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Client>  Clients { get; set; }

    

    }
}
