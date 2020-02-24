using dotnet_app_with_angular.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_app_with_angular.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options) {}

public DbSet<Value> Values { get; set; }
  }
}