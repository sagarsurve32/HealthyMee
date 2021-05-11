using HealthyMee.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HealthyMee.Views
{
    public partial class PatientListPage : ContentPage
    {
        PatientListViewModel _viewModel;
        public PatientListPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new PatientListViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}