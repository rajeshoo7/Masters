﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Masters.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Degree> Degrees { get; set; }
        public DbSet<Requirement> Requirements { get; set; }
        public DbSet<DegreeRequirement> DegreeRequirements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Degree>().ToTable("Degree");
            modelBuilder.Entity<Requirement>().ToTable("Requirements");
            modelBuilder.Entity<DegreeRequirement>().ToTable("DegreeRequirement");
        }


    }
}
