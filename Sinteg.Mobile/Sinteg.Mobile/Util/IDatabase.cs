using SQLite;

namespace Sinteg.Mobile.Util
{
    public interface IDatabase
    {
        SQLiteConnection GetConnection();
    }
}
