using System.ComponentModel;

namespace MauiProjectDraft.Views;

public partial class ProfileOptionsPage : ContentPage, INotifyPropertyChanged
{
    private bool _workerRecruiterNotSelected;
    public bool WorkerRecruiterNotSelected
    {
        get => _workerRecruiterNotSelected;
        set
        {
            _workerRecruiterNotSelected = value;
            OnPropertyChanged(nameof(WorkerRecruiterNotSelected));
        }
    }

    public ProfileOptionsPage()
    {
        WorkerRecruiterNotSelected = true;
        InitializeComponent();
        BindingContext = this; 
    }
    private void OnWorkerSelected(object sender, EventArgs e)
    {
        WorkerRecruiterNotSelected = false;
        WorkerSection.IsVisible = true;
        RecruiterSection.IsVisible = false;
    }

    private void OnRecruiterSelected(object sender, EventArgs e)
    {
        WorkerRecruiterNotSelected = false;
        WorkerSection.IsVisible = false;
        RecruiterSection.IsVisible = true;
    }

    private async void OnWorkerRegister(object sender, EventArgs e)
    {
        await DisplayAlert("Success", "Worker profile completed!", "OK");
    }

    private async void OnRecruiterRegister(object sender, EventArgs e)
    {
        await DisplayAlert("Success", "Recruiter profile completed!", "OK");
    }



    private async void OnPickFileClicked(object sender, EventArgs e)
    {
        var result = await FilePicker.PickAsync();

        if (result != null)
        {
            string fileName = result.FileName;
            string filePath = result.FullPath;

            await DisplayAlert("File Selected", $"Name: {fileName}\nPath: {filePath}", "OK");
        }
    }

}