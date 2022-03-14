using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinArchitecture.Services.Customer;

[assembly: Dependency(typeof(CustomerServices))] //We can add dependencies like that also we can add in app class
namespace XamarinArchitecture.Services.Customer
{
    public class CustomerServices : ICustomerServices
    {
        //We are gonna code Method here to get data and we are supposed to use interfaces on pages. Due to that we will write above namespace dependency

        SQLiteConnection conn;

        public CustomerServices()
        {
        }
    }
}
