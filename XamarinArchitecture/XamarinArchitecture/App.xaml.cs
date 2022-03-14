using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinArchitecture.Services;
using XamarinArchitecture.Services.Base;
using XamarinArchitecture.Services.Customer;
using XamarinArchitecture.Views;

namespace XamarinArchitecture
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //DependencyService.Register<IBaseServices, BaseServices>();
            //DependencyService.Register<ICustomerServices, CustomerServices>();
            //DependencyService.Register<MockDataStore>();

            MainPage = new HomePage();
        }

        protected override void OnStart()
        {
            //It works When Project Run
        }

        protected override void OnSleep()
        {
            //It works when project in sleep mode
        }

        protected override void OnResume()
        {
            //It works when project open after sleep mode
        }
    }
}
