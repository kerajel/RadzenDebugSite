using Microsoft.EntityFrameworkCore;
using RadzenDebugSite.Models;

namespace RadzenDebugSite.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    // Domain Entities
    public DbSet<Series> Series { get; set; }
}