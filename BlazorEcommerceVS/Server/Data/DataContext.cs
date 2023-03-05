using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerceVS.Server.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DbContext> options): base(options)
    {
        
    }
    
    public DbSet<Product> Products { get; set; }
}