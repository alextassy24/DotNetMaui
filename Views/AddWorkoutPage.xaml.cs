using FitnessTracker.Models;

namespace FitnessTracker.Views
{
    public partial class AddWorkoutPage : ContentPage
    {
        public AddWorkoutPage()
        {
            InitializeComponent();
        }

        private void WorkoutCtrl_OnSave(object sender, EventArgs e)
        {
            WorkoutRepo.AddWorkout(
                new Workout { Name = workoutCtrl.Name, Description = workoutCtrl.Description }
            );
            Shell.Current.GoToAsync($"//{nameof(WorkoutsPage)}");            
        }

        private void WorkoutCtrl_OnCancel(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync($"//{nameof(WorkoutsPage)}");            
         }

        private void WorkoutCtrl_OnError(object sender, EventArgs e)
        {
             DisplayAlert("Error", e.ToString(), "OK");
        }
    }
}
