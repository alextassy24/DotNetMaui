using FitnessTracker.Views;

namespace FitnessTracker
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // ! Routing
            // Workouts
            Routing.RegisterRoute(nameof(WorkoutsPage), typeof(WorkoutsPage));
            Routing.RegisterRoute(nameof(AddWorkoutPage), typeof(AddWorkoutPage));
            Routing.RegisterRoute(nameof(EditWorkoutPage), typeof(EditWorkoutPage));
        }
    }
}
