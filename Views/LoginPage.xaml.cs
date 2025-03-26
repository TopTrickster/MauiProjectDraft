namespace MauiProjectDraft.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void NavigateToProfileCommand(object sender, EventArgs e)
    {
        //await Shell.Current.GoToAsync("profile"); 
        await Navigation.PushAsync(new ProfilePage());
    }

    private async void NavigateToForgottenPasswordCommand(object sender, EventArgs e)
    {
        //await Shell.Current.GoToAsync("forgottenpassword"); 
        await Navigation.PushAsync(new ForgottenPasswordPage());
    }

    private async void NavigateToSignupCommand(object sender, EventArgs e)
    {
        //await Shell.Current.GoToAsync("signup"); 
        await Navigation.PushAsync(new SignupPage());
    }
}
