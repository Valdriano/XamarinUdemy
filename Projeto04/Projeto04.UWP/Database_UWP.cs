using Projeto04.UWP;
using SQLite;
using System.IO;
using Windows.Storage;

[assembly: Xamarin.Forms.Dependency( typeof( Database_UWP ) )]
namespace Projeto04.UWP
{
    public class Database_UWP : IDatabase
    {
        public SQLiteConnection GetConnection()
        {
            string database = Path.Combine( ApplicationData.Current.LocalFolder.Path , "Projeto04.db3" );

            return new SQLiteConnection( database );
        }
    }
}
