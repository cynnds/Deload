using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using Deload.DAL;
using Deload.Models;
using Microsoft.AspNet.Identity;

namespace Deload.Migrations
{
    public class WorkoutInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<WorkoutContext>
    {
        protected override void Seed(WorkoutContext context)
        {
            var passwordHash = new PasswordHasher();
            string password = passwordHash.HashPassword("test");
            var users = new List<ApplicationUser>
            {
                new ApplicationUser
                {
                    UserName = "testadmin@test.com",
                    PasswordHash = password,
                    PhoneNumber = "020202"
                }
            };

            users.ForEach(u => context.AspNetUsers.Add(u));
            context.SaveChanges();

            var workouts = new List<WorkoutModels>
            {
                new WorkoutModels {Name = "Barbell bench press", Description = "<p>This is a test</p>", Category = "Chest"},
                new WorkoutModels {Name = "Barbell back squat", Description = "<p>This is a test</p>", Category = "Legs"},
                new WorkoutModels {Name = "Incline dumbbell bench press", Description = "<p>This is a test</p>", Category = "Chest"},
            };
            workouts.ForEach(w => context.Workouts.Add(w));
            context.SaveChanges();
        }
    }
}