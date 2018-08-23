using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using TennisAppV2.Src.Data.DatabasePath;

[assembly: Xamarin.Forms.Dependency(typeof(TennisAppV2.Droid.Src.Data.DatabasePath))]
namespace TennisAppV2.Droid.Src.Data
{
    public class DatabasePath : IDatabasePath

    {
        public string DbConnectionPath()
        {
            var dbName = "TennisTestApp2Database.db3";
            return Path.Combine(System.Environment.
            GetFolderPath(System.Environment.
            SpecialFolder.Personal), dbName);
        }
    }
}