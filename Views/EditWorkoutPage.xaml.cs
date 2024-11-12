using FitnessTracker.Models;

namespace FitnessTracker.Views;

[QueryProperty(nameof(WorkoutId), "Id")]
public partial class EditWorkoutPage : ContentPage
{
    private Workout? workout;

    public EditWorkoutPage()
    {
        InitializeComponent();
    }

    private void BtnCancel_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    public int WorkoutId
    {
        set
        {
            workout = WorkoutRepo.GetWorkoutById(value);
            if (workout != null)
            {
                workoutCtrl.Name = workout.Name;
                workoutCtrl.Description = workout.Description;
            }
        }
    }

    public void BtnUpdate_Clicked(object sender, EventArgs e)
    {
        workout.Name = workoutCtrl.Name;
        workout.Description = workoutCtrl.Description;

        WorkoutRepo.UpdateWorkout(workout.Id, workout);
        Shell.Current.GoToAsync("..");
    }

    public void WorkoutCtrl_OnError(object sender, string errorMessage)
    {
        DisplayAlert("Error", errorMessage, "OK");
    }

}
