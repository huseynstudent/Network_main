using Microsoft.EntityFrameworkCore;
namespace Network_main;

public class Context: DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-5566K3T;Initial Catalog=Server;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True");
        base.OnConfiguring(optionsBuilder);
    }
    public DbSet<User.User> Users { get; set; }
}