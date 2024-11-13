using System.Collections.ObjectModel;
using FitnessTracker.Models;

namespace FitnessTracker.Views;

public partial class WorkoutsPage : ContentPage
{
    public WorkoutsPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        SearchBar.Text = string.Empty;
        LoadWorkouts();
    }

    public async void ListWorkouts_ItemSelected(object sender, EventArgs e)
    {
        if (listWorkouts.SelectedItem != null)
        {
            await Shell.Current.GoToAsync(
                $"{nameof(EditWorkoutPage)}?Id={((Workout)listWorkouts.SelectedItem).Id}"
            );
        }
    }

    public void ListWorkouts_ItemTapped(object sender, EventArgs e)
    {
        listWorkouts.SelectedItem = null;
    }

    public async void BtnAdd_Clicked(object sender, EventArgs e)
    {
        try
        {
            await Shell.Current.GoToAsync(nameof(AddWorkoutPage));
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error add btn clicked", $"Exception: {ex.Message}\n{ex.StackTrace}", "OK");
        }
    }

    public void MenuItem_Clicked(object sender, EventArgs e)
    {
        var menuItem = sender as MenuItem;
        if (menuItem?.CommandParameter is not Workout workout)
            return;

        WorkoutRepo.RemoveWorkout(workout.Id);
        LoadWorkouts();
    }

    private void LoadWorkouts()
    {
        var workouts = new ObservableCollection<Workout>(WorkoutRepo.GetWorkouts());
        listWorkouts.ItemsSource = workouts;
    }

    public void SearchBar_TextChanged(object sender, EventArgs e)
    {
        var workouts = new ObservableCollection<Workout>(
            WorkoutRepo.SearchWorkouts(((SearchBar)sender).Text)
        );
        listWorkouts.ItemsSource = workouts;
    }
}
