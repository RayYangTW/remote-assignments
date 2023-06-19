using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_1.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Assignment_1.Data
{
  public class assignmentContext : DbContext
  {
    public assignmentContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<User> User { get; set; }
  }
}