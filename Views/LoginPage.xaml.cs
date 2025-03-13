namespace MauiProjectDraft.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void NavigateToProfileCommand(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("profile"); 
    }

    private async void NavigateToForgottenPasswordCommand(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("forgottenpassword"); 
    }

    private async void NavigateToSignupCommand(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("signup"); 
    }
}
