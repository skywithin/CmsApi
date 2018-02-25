using CmsApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CmsApi.Data
{
    public class CmsApiContext : DbContext
    {
        public CmsApiContext(DbContextOptions<CmsApiContext> options) : base(options)
        {
        }

        public DbSet<Page> Pages { get; set; }

        public DbSet<Sidebar> Sidebar { get; set; }

        public DbSet<User> Users { get; set; }

    }
}
