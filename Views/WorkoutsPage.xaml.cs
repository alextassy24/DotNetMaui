using FitnessTracker.Models;

namespace FitnessTracker.Views;

public partial class WorkoutsPage : ContentPage
{
    public WorkoutsPage()
    {
        InitializeComponent();

        List<Workout> workouts = WorkoutRepo.GetWorkouts();

        listWorkouts.ItemsSource = workouts;
    }

    public async void ListWorkouts_ItemSelected(object sender, EventArgs e)
    {
        if(listWorkouts.SelectedItem != null)
        {
           await  Shell.Current.GoToAsync($"{nameof(EditWorkoutPage)}?Id={((Workout)listWorkouts.SelectedItem).Id}");
        }
    }

    public void ListWorkouts_ItemTapped(object sender, EventArgs e)
    {
        listWorkouts.SelectedItem = null;
    }
}
