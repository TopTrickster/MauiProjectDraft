using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace MauiProjectDraft
{
    public partial class AppShell : Shell
    {
        public bool IsLoading { get; set; }

        public bool IsLoaderVisible { get; set; }

        public AppShell()
        {
            IsLoading = true;
            OnPropertyChanged(nameof(IsLoading));
            IsLoaderVisible = true;
            OnPropertyChanged(nameof(IsLoaderVisible));
            InitializeComponent();
            
            Routing.RegisterRoute("MainPage", typeof(Views.MainPage));
            Routing.RegisterRoute("login", typeof(Views.LoginPage));
            Routing.RegisterRoute("signup", typeof(Views.SignupPage));

            NavigateToLoginCommand = new Command(async () => await Shell.Current.GoToAsync("login"));

            NavigateToSignUpCommand = new Command(async () => await Shell.Current.GoToAsync("signup"));
                
            NavigateToHomeCommand = new Command(async () => await Shell.Current.GoToAsync("MainPage"));

            Navigating += (s, e) => Shell.Current.FlyoutIsPresented = false;

            BindingContext = this;
            IsLoading = false;
            OnPropertyChanged(nameof(IsLoading));
            IsLoaderVisible = false;
            OnPropertyChanged(nameof(IsLoaderVisible));
        }

        public ICommand NavigateToLoginCommand { get; private set; }
        public ICommand NavigateToSignUpCommand { get; private set; }
        public ICommand NavigateToHomeCommand { get; private set; }

        private async void FlyoutList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string[] flyoutRoutes = { "MainPage", "MainPage", "MainPage", "login", "signup" };
            FlyoutItem selected = ((FlyoutItem)e.CurrentSelection.First());
            int i = 0;
            foreach (IReadOnlyList<Element> list in FlyoutItems)
            {
                foreach (object item in list)
                {
                    if (selected == item)
                    {
                        IsLoading = true;
                        OnPropertyChanged(nameof(IsLoading));
                        IsLoaderVisible = true;
                        OnPropertyChanged(nameof(IsLoaderVisible));
                        await Shell.Current.GoToAsync(flyoutRoutes[i]);
                        IsLoading = false;
                        OnPropertyChanged(nameof(IsLoading));
                        IsLoaderVisible = false;
                        OnPropertyChanged(nameof(IsLoaderVisible));
                    }
                    i++;
                }
            }
        }
    }
}
