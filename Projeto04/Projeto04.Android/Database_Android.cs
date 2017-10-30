using SQLite;
using System.IO;
using Projeto04.Droid;

[assembly: Xamarin.Forms.Dependency( typeof( Database_Android ) )]
namespace Projeto04.Droid
{
    public class Database_Android : IDatabase
    {
        public SQLiteConnection GetConnection()
        {
            string database = Path.Combine( System.Environment.GetFolderPath( System.Environment.SpecialFolder.Personal ) , "Projeto04.db3" );

            return new SQLiteConnection( database );
        }
    }
}