using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using NHR.Entity;

namespace NHR.Repository
{
    public class NHRContext:DbContext
    {
        public NHRContext()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=NHR;User ID=sa;Password=sa;pooling=true;max pool size=40000");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<User> Users { get; set; } 
    }
}
