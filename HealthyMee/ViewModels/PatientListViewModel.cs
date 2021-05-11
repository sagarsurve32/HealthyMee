using HealthyMee.Models;
using HealthyMee.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HealthyMee.ViewModels
{
    public class PatientListViewModel : BaseViewModel
    {
        public ObservableCollection<Patient> Patients { get; }
        public Command LoadPatientsCommand { get; }
        public PatientListViewModel()
        {
            Title = "Patient";
            Patients = new ObservableCollection<Patient>();
            LoadPatientsCommand = new Command(async () => await ExecuteLoadPatientsCommand());
        }

        async Task ExecuteLoadPatientsCommand()
        {
            IsBusy = true;

            try
            {
                Patients.Clear();
                var patients = await PatientStore.GetItemsAsync(true);
                foreach (var patient in patients)
                {
                    Patients.Add(patient);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }
    }
}
