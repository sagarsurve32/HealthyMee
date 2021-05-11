using HealthyMee.Services;
using HealthyMee.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HealthyMee
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            DependencyService.Register<PatientStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
