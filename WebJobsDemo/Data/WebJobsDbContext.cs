using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace WebJobsDemo.Data
{
    public class WebJobsDbContext : DbContext
    {
        public WebJobsDbContext(DbContextOptions<WebJobsDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
