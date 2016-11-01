using Xamarin.Forms;
using HeadWorksTask.ViewModels;
using HeadWorksTask.Views;
using System;

namespace HeadWorksTask
{
    public partial class LoginPage : ContentPage
    {
        private LoginPageViewModel ViewModel
        {
            get;
        }

        public LoginPage()
        {
            BindingContext = ViewModel = new LoginPageViewModel();
            InitializeComponent();
        }

        public async void OnButtonClick(object sender, EventArgs e)
        {
            if (ViewModel.Authorize())
                await Navigation.PushAsync(new StudentsList());
        }
    }
}
