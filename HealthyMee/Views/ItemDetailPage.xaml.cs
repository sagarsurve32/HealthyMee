using HealthyMee.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace HealthyMee.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}