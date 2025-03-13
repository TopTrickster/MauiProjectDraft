using System;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace MauiProjectDraft
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("login", typeof(Views.LoginPage));
            Routing.RegisterRoute("signup", typeof(Views.SignupPage));

            NavigateToLoginCommand = new Command(async () =>
            {
                await Shell.Current.GoToAsync("login");
                Shell.Current.FlyoutIsPresented = false; 
            });

            NavigateToSignUpCommand = new Command(async () =>
            {
                await Shell.Current.GoToAsync("signup");
                Shell.Current.FlyoutIsPresented = false; 
            });

            Navigating += (s, e) => Shell.Current.FlyoutIsPresented = false;

            BindingContext = this;
        }

        public ICommand NavigateToLoginCommand { get; }
        public ICommand NavigateToSignUpCommand { get; }
    }
}
