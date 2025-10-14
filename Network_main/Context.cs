using Microsoft.EntityFrameworkCore;
namespace Network_main;

public class Context: DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=STHQ0128-08;Initial Catalog=ServerNetwork;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True");
        base.OnConfiguring(optionsBuilder);
    }
    public DbSet<User.User> Users { get; set; }
}
