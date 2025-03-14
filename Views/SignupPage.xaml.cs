namespace MauiProjectDraft.Views;

public partial class SignupPage : ContentPage
{
    public SignupPage()
    {
        InitializeComponent();
    }

    private async void NavigateToEmailVerificationCommand(object sender, EventArgs e)
    {
        //await Shell.Current.GoToAsync("emailverification"); 
        await Navigation.PushAsync(new EmailVerificationPage());
    }

    private async void NavigateToLoginCommand(object sender, EventArgs e)
    {
        //await Shell.Current.GoToAsync("login"); 
        await Navigation.PushAsync(new LoginPage());
    }
}
