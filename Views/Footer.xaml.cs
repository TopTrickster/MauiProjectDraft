namespace MauiProjectDraft.Views;

public partial class Footer : ContentView
{
	public Footer()
	{
		InitializeComponent();
	}
    private async void OnAboutUsTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AboutUsPage());
    }
}