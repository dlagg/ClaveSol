using Microsoft.EntityFrameworkCore;
using ClaveSol.Models;
public class AppDbContext:DbContext
{
   public AppDbContext(DbContextOptions<AppDbContext> options) :
   base(options)
   {
   }

   public DbSet<User> User {get; set;}
}