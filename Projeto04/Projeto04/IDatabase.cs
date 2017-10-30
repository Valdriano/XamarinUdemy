using SQLite;

namespace Projeto04
{
    public interface IDatabase
    {
        SQLiteConnection GetConnection();
    }
}
