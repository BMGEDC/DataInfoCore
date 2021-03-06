﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataInfoCore.Models;
using Microsoft.EntityFrameworkCore;

namespace DataInfoCore.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Contact>()
                 .HasIndex(u => u.EMail)
                 .IsUnique();
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Market> Market { get; set; }
        public DbSet<Config> Config { get; set; }
        public DbSet<Wholesaler> Wholesaler { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Communication> Communication { get; set; }
        public DbSet<Processlog> Processlog { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<ContactRole> ContactRole { get; set; }
        public DbSet<WholesalerInfo> WholesalerInfo { get; set; }
    }
}
