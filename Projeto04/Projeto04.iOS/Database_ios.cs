using Projeto04.iOS;
using System;
using SQLite;
using System.IO;

[assembly: Xamarin.Forms.Dependency( typeof( Database_IOS ) )]
namespace Projeto04.iOS
{
    public class Database_IOS : IDatabase
    {
        public SQLiteConnection GetConnection()
        {
            string database = Path.Combine( Environment.GetFolderPath( Environment.SpecialFolder.Personal ) , ".." , "Library" , "Projeto04.db3" );

            return new SQLiteConnection( database );
        }
    }
}
