using HealthyMee.ViewModels;
using HealthyMee.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace HealthyMee
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(PatientListPage), typeof(PatientListPage));
            Routing.RegisterRoute(nameof(AppointmentPage), typeof(AppointmentPage));
            Routing.RegisterRoute(nameof(MedicinePage), typeof(MedicinePage));
            Routing.RegisterRoute(nameof(FacilityPage), typeof(FacilityPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
