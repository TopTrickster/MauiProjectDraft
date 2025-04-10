namespace MauiProjectDraft.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnAboutUsTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutUsPage());
        }
    }
}
