namespace FitnessTracker.Views;

public partial class AddWorkoutPage : ContentPage
{
    public AddWorkoutPage()
    {
        InitializeComponent();
    }

    private void BtnCancel_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
}
