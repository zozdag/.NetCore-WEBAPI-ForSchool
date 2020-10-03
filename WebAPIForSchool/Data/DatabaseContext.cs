using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIForSchool.Models;

namespace WebAPIForSchool.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> opt) : base(opt)
        {
               //DbContextOptions
        }

        public DbSet<Student> Students { get; set; }// For LINQ Quearies



    }
}
