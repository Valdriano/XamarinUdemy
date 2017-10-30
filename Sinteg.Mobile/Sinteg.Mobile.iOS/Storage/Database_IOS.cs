using Sinteg.Mobile.Util;
using System;
using SQLite;
using System.IO;
using Xamarin.Forms;
using Sinteg.Mobile.iOS.Storage;

[assembly: Dependency( typeof( Database_IOS ) )]
namespace Sinteg.Mobile.iOS.Storage
{
    public class Database_IOS : IDatabase
    {
        public SQLiteConnection GetConnection()
        {
            string database = Path.Combine( Environment.GetFolderPath( Environment.SpecialFolder.Personal ) , ".." , "Library" , "dbsinteg.db3" );

            return new SQLiteConnection( database );
        }
    }
}