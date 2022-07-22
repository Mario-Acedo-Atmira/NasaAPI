using Microsoft.EntityFrameworkCore;
using NasaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NasaAPI.Context
{
    public class ContextoDB :DbContext,IContextoDB
    {
        public ContextoDB(DbContextOptions<ContextoDB> options) : base(options)
        {

        }

        public DbSet<Meteorito> meteoritos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Meteorito>().ToTable("Meteoritos");
        }
    }
    
}
