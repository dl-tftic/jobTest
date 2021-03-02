using ex2_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex2_DAL.EF
{
    public class DalContext : DbContext
    {
        public DalContext() 
        {
            

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=C:\Users\lisse\source\repos\dl-tftic\jobTest\ex2_DAL\Db\api.db;");
            base.OnConfiguring(optionsBuilder);
            SQLitePCL.Batteries.Init();
        }


        public DbSet<Person> Person { get; set; }
    }
}
