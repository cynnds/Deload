using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Deload.Models;

namespace Deload.DAL
{
    public class WorkoutContext : DbContext
    {
        public WorkoutContext() : base("WorkoutContext")
        {
            
        }

        public DbSet<WorkoutModels> Workouts { get; set; }
        public DbSet<ApplicationUser> AspNetUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}