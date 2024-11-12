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
        public static Workout? GetWorkoutById(int id)
        {
            var workout = workouts.FirstOrDefault(w => w.Id == id);
            if(workout != null)
            {
                return new Workout{
                    Id = workout.Id,
                    Name = workout.Name,
                    Description = workout.Description
                };
            }

            return null;
        } 
        public static void UpdateWorkout(int id, Workout workout)
        {
            if(id != workout.Id) return;

            var workoutToUpdate = workouts.FirstOrDefault(x => x.Id == id); 
            if (workoutToUpdate != null)
            {
                workoutToUpdate.Name = workout.Name;
                workoutToUpdate.Description = workout.Description;
            }
        }

        public static void RemoveWorkout(int id)
        {
            var workoutToRemove = workouts.FirstOrDefault(x => x.Id == id);
            if (workoutToRemove != null)
            {
                workouts.Remove(workoutToRemove);
            }
        }
    }
}