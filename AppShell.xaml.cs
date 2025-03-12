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

            BindingContext = this;
            }

            public ICommand NavigateToLoginCommand { get; }
            public ICommand NavigateToSignUpCommand { get; }
        }
    }
