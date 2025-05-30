using System;
using Microsoft.EntityFrameworkCore;

namespace ArchiveApi.Models;

public class AppDbContext : DbContext
{

  public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
  {

  }
  public DbSet<Item> Items {get; set;}

  public DbSet<Users> Users {get; set;}
}
