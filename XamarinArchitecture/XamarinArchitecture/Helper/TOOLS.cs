using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace XamarinArchitecture.Helper
{
    public class TOOLS
    {
        public static string DBName = "XamarinArchitecture.14032022";
        public static SQLiteConnection SQLConnection = new SQLiteConnection(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DBName));


    }
}
