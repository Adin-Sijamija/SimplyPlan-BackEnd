using Microsoft.EntityFrameworkCore;
using SimplyPlan.Core.Entities;

namespace SimplyPlan.Infrastructure.EF
{
    public class SimplyPlanContext : DbContext
    {
        public SimplyPlanContext(DbContextOptions options) : base(options)
        {

        }

        protected SimplyPlanContext()
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Objective> Objectives { get; set; }


    }
}
