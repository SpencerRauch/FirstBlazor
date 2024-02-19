using FirstBlazor.Models;
using Microsoft.EntityFrameworkCore;
namespace FirstBlazor.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    public DbSet<VideoGame> VideoGames { get;set; }
}