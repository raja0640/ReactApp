using System.Diagnostics;
using Jnr.Technologies.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace Jnr.Technologies.Persistence;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<ActivityModel> Activities { get; set; }
}