﻿using Entity_Framework.Configurations;
using Entity_Framework.Entities;
using System.Data.Entity;

namespace Entity_Framework.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("InternationWidgets")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppDbContext, Migrations.Configuration>());
        }

        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ItemConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}