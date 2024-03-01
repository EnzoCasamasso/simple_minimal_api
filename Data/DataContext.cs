using Microsoft.EntityFrameworkCore;
using MinimalApi.UserRoute;

namespace MinimalApi.Data;

public class DataContext : DbContext
{
    public DbSet<User> Users { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Banco.sqlite");
        base.OnConfiguring(optionsBuilder);
    }
}
