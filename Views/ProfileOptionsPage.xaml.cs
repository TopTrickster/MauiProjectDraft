namespace MauiProjectDraft.Views;

public partial class ProfileOptionsPage : ContentPage
{
	public ProfileOptionsPage()
	{
		InitializeComponent();
	}
    private void OnWorkerSelected(object sender, EventArgs e)
    {
        WorkerSection.IsVisible = true;
        RecruiterSection.IsVisible = false;
    }

    private void OnRecruiterSelected(object sender, EventArgs e)
    {
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

}