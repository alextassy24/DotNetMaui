using FitnessTracker.Models;

namespace FitnessTracker.Views;

[QueryProperty(nameof(WorkoutId), "Id")]
public partial class EditWorkoutPage : ContentPage
{
    private Workout workout;

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
            lblName.Text = workout.Name;
        }
    }
}
