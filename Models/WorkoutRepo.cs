namespace FitnessTracker.Models
{
    public static class WorkoutRepo
    {
        public static List<Workout> workouts = [
            new Workout { Id = 1, Name = "Running", Description = "A cardiovascular exercise that involves running." },
            new Workout { Id = 2, Name = "Cycling", Description = "An outdoor exercise that involves riding a bicycle." },
            new Workout { Id = 3, Name = "Swimming", Description = "An aerobic exercise that involves swimming." }
        ];

        public static List<Workout> GetWorkouts() => workouts;
        public static Workout GetWorkoutById(int id) => workouts.FirstOrDefault(w => w.Id == id);
    }
}