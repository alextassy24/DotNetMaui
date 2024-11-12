namespace FitnessTracker.Views.Controls;

public partial class WorkoutControl : ContentView
{
    public event EventHandler<string>? OnError;
    public event EventHandler<EventArgs>? OnSave;
    public event EventHandler<EventArgs>? OnCancel;

    public WorkoutControl()
    {
        InitializeComponent();
    }

    public string Name
    {
        get { return entryName.Text; }
        set { entryName.Text = value; }
    }

    public string Description
    {
        get { return entryDescription.Text; }
        set { entryDescription.Text = value; }
    }

    private void BtnSave_Clicked(object sender, EventArgs e)
    {
        if (nameValidator.IsNotValid)
        {
            OnError?.Invoke(sender, "Name is required");
            return;
        }

        if (descriptionValidator.IsNotValid && descriptionValidator.Errors != null)
        {
            foreach (var error in descriptionValidator.Errors)
            {
                OnError?.Invoke(sender, error?.ToString() ?? "Unknown error");
            }
            return;
        }

        OnSave?.Invoke(sender, e);
    }

    private void BtnCancel_Clicked(object sender, EventArgs e)
    {
        OnCancel?.Invoke(sender, e);
    }
}
