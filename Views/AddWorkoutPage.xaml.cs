using FitnessTracker.Models;

namespace FitnessTracker.Views
{
    public partial class AddWorkoutPage : ContentPage
    {
        public AddWorkoutPage()
        {
            InitializeComponent();
        }

        private async void WorkoutCtrl_OnSave(object sender, EventArgs e)
        {
            try
            {
                WorkoutRepo.AddWorkout(
                    new Workout { Name = workoutCtrl.Name, Description = workoutCtrl.Description }
                );
                await DisplayAlert("Status", "Workout saved", "OK");
                await Shell.Current.GoToAsync("..");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error on save", $"Save failed: {ex}", "OK");
            }
        }

        private async void WorkoutCtrl_OnCancel(object sender, EventArgs e)
        {
            try
            {
                await Shell.Current.GoToAsync("..");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error on cancel", $"Navigation failed: {ex}", "OK");
            }
        }

        private void WorkoutCtrl_OnError(object sender, EventArgs e)
        {
            DisplayAlert("Error", e.ToString(), "OK");
        }
    }
}
