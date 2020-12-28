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

        public DbSet<Post> Post { get; set; }
    }
}
