using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace codeFirstApproach.Models
{
    public class ApplicationDbContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-1386F6G; user id=sa;password=login;database=MyPersonDB");
        }

        public DbSet<Person> Customers { get; set; }
        public DbSet<Student> Staffs { get; set; }
        public DbSet<Grade> Sales { get; set; }


    }
}
