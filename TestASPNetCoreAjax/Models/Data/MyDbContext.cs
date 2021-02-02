using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestASPNetCoreAjax.Models.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<Sharp> Sharps { get; set; }
        public DbSet<Js> Js { get; set; }
        
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
