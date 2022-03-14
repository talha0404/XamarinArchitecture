using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinArchitecture.Services.Customer;

namespace XamarinArchitecture.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        private readonly ICustomerServices _customerServices;
        public HomePage()
        {
            InitializeComponent();
            _customerServices = DependencyService.Get<ICustomerServices>(); //To use services
        }
    }
}