using System;
using Sinteg.Mobile.Util;
using SQLite;
using System.IO;
using Xamarin.Forms;
using Sinteg.Mobile.Droid.Storage;

[assembly: Dependency( typeof( Database_Android ) )]
namespace Sinteg.Mobile.Droid.Storage
{
    public class Database_Android : IDatabase
    {
        public SQLiteConnection GetConnection()
        {
            string database = Path.Combine( Environment.GetFolderPath( Environment.SpecialFolder.Personal ) , "dbsinteg.db3" );

            return new SQLiteConnection( database );
        }
    }
}