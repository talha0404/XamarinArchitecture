using System;
using System.Collections.Generic;
using System.Text;
using XamarinArchitecture.Models;

namespace XamarinArchitecture.Helper
{
    public class Synchronization
    {
        public Synchronization()
        {

        }

        public void CreateTable()
        {
            TOOLS.SQLConnection.Execute("PRAGMA auto_vacuum = FULL;"); //Tablolari Sıkıştırıyor

            TOOLS.SQLConnection.CreateTable<Customer>(); //We are creating Table when project run
        }

        public void DropTable()
        {
            TOOLS.SQLConnection.DropTable<Customer>(); //We are dropping Table when project run
        }

        public void SynchronizationDropTable()
        {
            TOOLS.SQLConnection.DropTable<Customer>();

            TOOLS.SQLConnection.CreateTable<Customer>();
        }
    }
}
