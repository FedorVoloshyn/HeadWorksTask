using Xamarin.Forms;
using HeadWorksTask.ViewModels;
using HeadWorksTask.Views;
using System;

namespace HeadWorksTask.Views
{
    public partial class StudentsList : ContentPage
    {
        private StudentsPageViewModel ViewModel
        {
            get;
        }
        public StudentsList()
        {
            InitializeComponent();
            ViewModel = new StudentsPageViewModel();
            BindingContext = ViewModel;
            StudentsView.ItemsSource = ViewModel.StudentList;
        }
    }
}
