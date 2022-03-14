using System.ComponentModel;
using Xamarin.Forms;
using XamarinArchitecture.ViewModels;

namespace XamarinArchitecture.Views
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