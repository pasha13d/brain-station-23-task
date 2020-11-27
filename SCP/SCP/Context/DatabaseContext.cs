using Microsoft.EntityFrameworkCore;
using SCP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCP.Context
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostDetails>().HasKey(s => new { s.Id, s.PostsId });
        }

        public DbSet<Posts> Posts { get; set; }
        public DbSet<PostDetails> PostDetails { get; set; }
    }
}
