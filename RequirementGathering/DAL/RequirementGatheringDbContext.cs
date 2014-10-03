﻿using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.AspNet.Identity.EntityFramework;
using RequirementGathering.Models;

namespace RequirementGathering.DAL
{
    public class RequirementGatheringDbContext : IdentityDbContext<User>
    {
        public RequirementGatheringDbContext()
            : base("RequirementGatheringDbContext")
        { }

        public DbSet<Evaluation> Evaluations { get; set; }
        public DbSet<Attribute> Attributes { get; set; }
        public DbSet<Version> Versions { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<VersionAttribute> VersionAttributes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public static RequirementGatheringDbContext Create()
        {
            return new RequirementGatheringDbContext();
        }
    }
}
