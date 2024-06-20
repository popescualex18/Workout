using Microsoft.EntityFrameworkCore;
using WorkoutApp.Domain;

namespace Workout.DataAccessLayer
{
    public partial class WorkoutDbContext : DbContext
    {
        public WorkoutDbContext()
        {
        }
        public WorkoutDbContext(DbContextOptions<WorkoutDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Excercise> Excercises { get; set; } = null!;
    }
}