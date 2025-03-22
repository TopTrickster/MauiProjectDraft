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

                NavigateToLoginCommand = new Command(async () => await Shell.Current.GoToAsync("login"));

                Routing.RegisterRoute("signup", typeof(Views.SignupPage));

                NavigateToSignUpCommand = new Command(async () => await Shell.Current.GoToAsync("signup"));

                Navigating += (s, e) => Shell.Current.FlyoutIsPresented = false;

                BindingContext = this;
            }

            public ICommand NavigateToLoginCommand { get; private set; }
            public ICommand NavigateToSignUpCommand { get; private set; }
        }
    }
