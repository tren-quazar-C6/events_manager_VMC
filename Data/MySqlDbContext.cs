using Microsoft.EntityFrameworkCore;
using sporting.Models;

namespace sporting.Data;

public class MySqlDbContext : DbContext
{
    public MySqlDbContext(DbContextOptions<MySqlDbContext> options) : base(options)
    {
    }

    public DbSet<Event> events { get; set; }
}