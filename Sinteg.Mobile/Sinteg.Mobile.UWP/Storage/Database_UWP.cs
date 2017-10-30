using Sinteg.Mobile.Util;
using SQLite;
using Windows.Storage;
using Xamarin.Forms;
using Sinteg.Mobile.UWP.Storage;
using System.IO;

[assembly: Dependency( typeof( Database_UWP ) )]
namespace Sinteg.Mobile.UWP.Storage
{
    public class Database_UWP : IDatabase
    {
        public SQLiteConnection GetConnection()
        {
            string database = Path.Combine( ApplicationData.Current.LocalFolder.Path , "dbsinteg.db3" );

            return new SQLiteConnection( database );
        }
    }
}
