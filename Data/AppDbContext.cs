
using Microsoft.EntityFrameworkCore;
using OrderFlow.Models;

namespace OrderFlow.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Order> Orders => Set<Order>();
}