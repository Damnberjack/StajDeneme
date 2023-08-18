using EFCore_Learning.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore_Learning.ApplicationDbContext;

public class AppbContext:DbContext
{
    public AppbContext(DbContextOptions<AppbContext> options) : base(options)
    {

    }
    public DbSet<Product> Products { get; set; }
}
