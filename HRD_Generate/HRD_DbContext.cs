﻿using Microsoft.EntityFrameworkCore;
using System.IO;
using HRD_DataLibrary.Models;
using Microsoft.Extensions.Configuration;

namespace HRD_Api.Data
{
    public class HRD_DbContext : DbContext
    {
        public HRD_DbContext(DbContextOptions<HRD_DbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<FiredEmployee> FiredEmployees { get; set; }
        public virtual DbSet<Holiday> Holidays { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Resume> Resumes { get; set; }
        public virtual DbSet<Reward> Rewards { get; set; }
        public virtual DbSet<Vacancy> Vacancies { get; set; }
        public virtual DbSet<WorkedTime> WorkedTimes { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
   
            var options = optionsBuilder
                .UseSqlite("DataSource=humanResourcesDepartment.db")
                .Options;
        }
    }
}
