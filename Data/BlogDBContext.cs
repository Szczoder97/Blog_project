using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Blog_project.Models;

namespace Blog_project.Models
{
    public class BlogDBContext : DbContext
    {
        public BlogDBContext(DbContextOptions<BlogDBContext> options)
           : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasKey(c => c.id);
            modelBuilder.Entity<Post>().ToTable("Posts");
            modelBuilder.Entity<Comment>().HasKey(c => c.id);
            modelBuilder.Entity<Comment>().ToTable("Comments")
        }

    

    }
}
