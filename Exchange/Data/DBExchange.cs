using Exchange.Data.Entity;
using Microsoft.EntityFrameworkCore;


namespace Exchange.Data
{
    public class DBContextExchange:DbContext
    {
        public DBContextExchange(DbContextOptions<DBContextExchange> options):base(options)
        {

        }

        public DbSet<ExchangeProvaidor> ExchangeProvadiors { get; set; }

        public DbSet<Reight> Reights { get; set; }
        

        
        
    }
}
