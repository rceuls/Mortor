using Microsoft.EntityFrameworkCore;

namespace Mortor.Web.Data
{
    public class MortorBlazorContext : DbContext
    {
        public MortorBlazorContext(DbContextOptions config) : base(config)
        {
            
        }
        
        public DbSet<Report> Reports { get; set; }
    }
}